using AlumniDigitalIDCreator.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlumniDigitalIDCreator.Model.Alumni_model;

namespace AlumniDigitalIDCreator
{
    public partial class PasswordGenerator : Form
    {
        string _process = "EMAIL ID";
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        public void displayRecord()
        {
            AlumniRepository _i = new AlumniRepository();
            try
            {
                lsvList.Items.Clear();
                List<AlumniList_model> _Models = _i.Get(_process);
                if (_Models.Count > 0)
                {
                    lblrecord.Text = "Record count : " + _Models.Count.ToString();
                    foreach (AlumniList_model _list in _Models)
                    {
                        ListViewItem _item = new ListViewItem(_list.AlumniNo.ToString());
                        _item.SubItems.Add(_list.AlumniName);
                        _item.SubItems.Add(_list.Degree);
                        _item.SubItems.Add(_list.Batch);
                        _item.SubItems.Add(_list.MemberType);
                        _item.SubItems.Add(_list.Expiration);
                        _item.SubItems.Add("");
                        _item.SubItems.Add(_list.UserId.ToString());
                        _item.SubItems.Add(_list.StudentGUID.ToString());
                        _item.SubItems.Add(_list.Id.ToString());

                        lsvList.Items.Add(_item);
                    }
                }
                else {
                    lblrecord.Text = "Record count : 0";
                    MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            displayRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on Hasing users password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            prb.Maximum = lsvList.Items.Count;
            prb.Value = 0;
            try
            {
                foreach (ListViewItem _item in lsvList.Items)
                {


                    string _alumnino = _item.Text;
                    string _alumniname = _item.SubItems[1].Text;
                    string _degree = _item.SubItems[2].Text;
                    string _batch = _item.SubItems[3].Text;
                    string _membertype = _item.SubItems[4].Text;
                    string _expiration = _item.SubItems[5].Text;
                    string _remarks = _item.SubItems[6].Text;
                    int _userid = int.Parse(_item.SubItems[7].Text);
                    string _guid = _item.SubItems[8].Text;
                    int _id = int.Parse(_item.SubItems[9].Text);

                    string _result = "Success";

                    AlumniRepository _i = new AlumniRepository();

                    string _password = _guid.Substring(0, 8);                    
                    _password = _i.Reverse(_password);
                    _password = _i.PasswordHasher(_password);

                    string _pin = _guid.Substring(0, 4);
                    _pin = _i.Reverse(_pin);
                    _pin = _i.PasswordHasher(_pin);


                    //update user password
                    if (!_i.HashPassword(_userid, _password, _pin))
                    {
                        _result = "Failed";
                    }
                    lsvList.Items[_item.Index].SubItems[6].Text = _result;

                    
                    if (_result == "Success") {
                        _i.LogProcess(_id, "PASSWORD HASH", _userid);
                        _result = _i.EmailUser(_userid);

                        
                        int milliseconds = 10000;
                        Thread.Sleep(milliseconds);
                    }

                    _item.SubItems[6].Text = _result;

                    lsvList.Refresh();
                    prb.Value = prb.Value + 1;
                }

                MessageBox.Show("Password successfully hashed and emailed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //displayRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayRecord();
        }
    }
}



