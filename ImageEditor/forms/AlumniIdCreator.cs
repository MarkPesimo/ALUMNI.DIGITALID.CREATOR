using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows;
using AlumniDigitalIDCreator.Repository;
using static AlumniDigitalIDCreator.Model.Alumni_model;
using System.Threading;
using System.IO;
using AlumniDigitalIDTool;

namespace AlumniDigitalIDCreator
{
    public partial class AlumniIdCreator : Form
    {
        public AlumniIdCreator()
        {
            InitializeComponent();
            txtOutput.Text = AlumniConstant.IDLocation;
            //cboMemberType.SelectedIndex = 0;
        }

        public bool GenerateCard(string _alumnino, string _alumniname, string _coursename, string _batch, string _membertype, string _expiration, int _userid, string _guid, int _id)
        {
            lblAlumniNo.Text = _alumnino;
            lblAlumniName.Text = _alumniname;
            lblCourseName.Text = _coursename;
            lblBatch.Text = _batch;
            //cboMemberType.Text = _membertype;
            lblExpiration.Text = "Expiry : " + _expiration;

            string _output_path = txtOutput.Text;

            if (File.Exists(AlumniConstant.QRLocation + _alumnino + ".png"))
            {
                picProfile.BackgroundImage = Image.FromFile(AlumniConstant.QRLocation + _alumnino + ".PNG"); // =  _output_path + @"\QR Codes\" + _alumnino + ".png";
                //picQR.BackgroundImage = Image.FromFile(AlumniConstant.QRLocation + _alumnino + ".png"); // =  _output_path + @"\QR Codes\" + _alumnino + ".png";               
                Thread.Sleep(2000);
                picQR_2.Update();
            }
            else
            {
                return false;
            }

            //ALUMNI MEMBER IMMAGE
            //if (File.Exists(AlumniConstant.ImageLocation + _guid + ".JPEG"))
            //{
            //    picProfile.BackgroundImage = Image.FromFile(AlumniConstant.ImageLocation + _guid + ".JPEG"); // =  _output_path + @"\QR Codes\" + _alumnino + ".png";
            //    Thread.Sleep(2000);
            //    picProfile.Update();
            //} 
            //else
            //{
            //    return false;
            //}
            


            panCard.Refresh();
            panCard.Update();

            if (_membertype == "Annual Member")
            {
                lblMemberType.Visible = true;
                lblExpiration.Visible = true;
                panCard.BackgroundImage = AlumniDigitalIDTool.Properties.Resources.Alumni_ID_Annual_blank; // @"C:\TEST PROGRAMS\ImageEditor\ImageEditor\ImageEditor\Card\Alumni-ID-Annual blank.jpg";
            }
            else
            {
                lblMemberType.Visible = false;
                lblExpiration.Visible = false;
                panCard.BackgroundImage = AlumniDigitalIDTool.Properties.Resources.Alumni_ID_Lifetime_blank; // @"C:\TEST PROGRAMS\ImageEditor\ImageEditor\ImageEditor\Card\Alumni-ID-Annual blank.jpg";
            }

            
            try
            {
             

                //Bitmap _bmp = new Bitmap(panel3.Width, panel3.Height);
                //                Bitmap _bmp = new Bitmap(int.Parse(txtbmp_width.Text), int.Parse(txtbmp_height.Text));
                //Bitmap _bmp = new Bitmap(@"C:\Users\MarkJPesimo\Downloads\Blank Alumni Template\Alumni-ID-Annual blank.jpg");
                Bitmap _bmp = new Bitmap(int.Parse(txtw.Text), int.Parse(txth.Text));
                //_bmp.SetResolution( 72, 72);

                Rectangle _rec = new Rectangle
                {
                    Height = int.Parse(txtbmp_height.Text),
                    Width = int.Parse(txtbmp_width.Text)
                };

                panCard.DrawToBitmap(_bmp, _rec);

              
                //_bmp.Save(_output_path + @"\" + _alumnino + " - " + DateTime.Now.ToString().Replace("/", "-").Replace(":", "-") + ".png");
                _bmp.Save(AlumniConstant.IDLocation + _alumnino + ".png");

                AlumniRepository _repository = new AlumniRepository();
                //_repository.LogProcess(_id , "ALUMNI ID CREATED", _userid);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on Generating Alumni DigitalId?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

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
                    int _userid = int.Parse( _item.SubItems[7].Text);
                    string _guid = _item.SubItems[8].Text;
                    int _id = int.Parse(_item.SubItems[9].Text);

                    string _result = "Success";
                    if (!GenerateCard(_alumnino, _alumniname, _degree, _batch, _membertype, _expiration, _userid, _guid, _id)) {
                        _result = "Failed";
                    }
                    lsvList.Items[_item.Index].SubItems[6].Text = _result;
                    
                    _item.SubItems[6].Text = _result;

                    lsvList.Refresh();
                    prb.Value = prb.Value + 1;
                }

                MessageBox.Show("Alumni DigitalId Successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //GenerateCard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        public void displayRecord()
        {
            AlumniRepository _i = new AlumniRepository();
            try
            {
                lsvList.Items.Clear();
                List<AlumniList_model> _Models = _i.Get("ALUMNI ID CREATED");
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
                        //_item.SubItems.Add(_list.StudenId.ToString());
                        _item.SubItems.Add(_list.StudentGUID.ToString());
                        _item.SubItems.Add(_list.Id.ToString());

                        lsvList.Items.Add(_item);
                    }

                    MessageBox.Show("Records successfully loaded!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtw_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            displayRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayRecord();
            //picQR.ImageLocation =  AlumniDigitalIDCreator.Properties.Resources.Childish_Cross;
        }
    }
}
