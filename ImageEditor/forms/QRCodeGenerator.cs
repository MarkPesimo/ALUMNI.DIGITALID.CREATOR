using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using AlumniDigitalIDCreator.Repository;
using static AlumniDigitalIDCreator.Model.Alumni_model;
using System.Threading;

namespace AlumniDigitalIDTool.forms
{
    public partial class QRCodeGenerator : Form
    {
        string _process = "QR CODE CREATED";

        public QRCodeGenerator()
        {
            InitializeComponent();
            txtpath.Text = AlumniConstant.QRLocation;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on Generating user QR Code?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

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

           

                    if (!generateQRCode(txtURL.Text, _guid, _alumnino))
                    {
                        _result = "Failed";
                    }
                    lsvList.Items[_item.Index].SubItems[6].Text = _result;

                    _item.SubItems[6].Text = _result;
                    if (_result == "Success")
                    {
                        _i.LogProcess(_id, _process, _userid);
                    }

                    lsvList.Refresh();
                    prb.Value = prb.Value + 1;
                }

                MessageBox.Show("User QR code successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //displayRecord(_process);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool generateQRCode(string _url, string _guid, string _alumnino)
        {
         

            try
            {

                string _qrcode = _url + _guid + System.Environment.NewLine;
                //System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml(txtColor.Text);
     

                var color = System.Drawing.ColorTranslator.FromHtml(txtColor.Text);

                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer()
                {
                    // Color.FromArgb(8, 42, 94)
                    Foreground = color
                };

                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;

                Bitmap bitmap = barcodeWriter.Write(_qrcode);

                picQR.Image = bitmap;
                Thread.Sleep(2000);
                picQR.Update();

                string _output_path = txtpath.Text;

                bitmap.Save(_output_path + _alumnino + ".png");


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayRecord(_process);
        }

        public void displayRecord(string _process)
        {
            AlumniRepository _i = new AlumniRepository();
            try
            {
                lsvList.Items.Clear();
                List<AlumniList_model> _Models = _i.Get(_process);
                if (_Models.Count != 0)
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

        private void QRCodeGenerator_Load(object sender, EventArgs e)
        {
            
            displayRecord("QR CODE CREATED");
        }
    }
}
