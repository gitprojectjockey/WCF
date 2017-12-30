using NALS.GeoLibrary.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

namespace NALS.GeoLibrary.Client
{
    public partial class Main : Form
    {
        string[] _zipsToUpdate = new string[] { "01072", "02334", "02657", "02666", "02660" };
        public Main()
        {
            InitializeComponent();
        }

        private void btnZipCode_Click(object sender, EventArgs e)
        {
            string zipCode = txtZipCode.Text;
            ZipCodeData zipCodeData;

            using (ServiceClient.GeoService proxy = new ServiceClient.GeoService())
            {
                proxy.ClientCredentials.UserName.UserName = txtUserName.Text;
                proxy.ClientCredentials.UserName.Password = txtPassword.Text;
                zipCodeData = proxy.GetZipCode(zipCode);
            }
            string[] dataToDisplay = new string[] { $"City: {zipCodeData.City}", $"Zip: {zipCodeData.ZipCode}" };
            lstDispay.Items.Add(dataToDisplay[0]);
            lstDispay.Items.Add(dataToDisplay[1]);
        }

        private void btnGetZipCodes_Click(object sender, EventArgs e)
        {
            lstDispay.Items.Clear();
            lstUpdate.Items.Clear();

            var state = txtState.Text;
            IEnumerable<ZipCodeData> zips;
            using (ServiceClient.GeoService proxy = new ServiceClient.GeoService())
            {
                proxy.ClientCredentials.UserName.UserName = txtUserName.Text;
                proxy.ClientCredentials.UserName.Password = txtPassword.Text;
                zips = proxy.GetZips(state);
            }
            Func<string, string, string> formatter = (zip, city) => $"{zip}--{city}";
            string[] zipCodedCities = GetFormattedZipData(formatter, zips.ToList()).ToArray();

            Func<string, bool> LoadList = delegate (string zip)
            {
                lstDispay.Items.Add(zip);
                return true;
            };

            Func<string, bool> LoadUpdateControls = (string zip) =>
            {
                var zipPart = zip.Substring(0, zip.IndexOf("--"));
                if (_zipsToUpdate.Contains(zipPart))
                {
                    lstUpdate.Items.Add(zip);
                    return true;
                }
                return false;
            };

            lblCount.Text = zipCodedCities.Count(zc => LoadList(zc)).ToString();
            zipCodedCities.Where(zc => LoadUpdateControls(zc)).ToArray();
            lstUpdate.SelectedIndex = 0;
        }
        private string[] GetFormattedZipData(Func<string, string, string> formatter, List<ZipCodeData> zipCodeData)
        {
            return zipCodeData.Select(x => formatter(x.ZipCode, x.City.ToUpper())).ToArray();
        }

        private void btnUpdateCityBatch_Click(object sender, EventArgs e)
        {
            var specialCode = txtPOCode.Text.Trim();
            Func<string, string, ZipCityData>  GetZipCityData = (string zipCity, string code) =>
            {
                var index = zipCity.IndexOf("--");
                var zipPart = zipCity.Substring(0, index);
                var cityPart = zipCity
                   .Substring(index, zipCity.Length - index)
                   .Replace("--", "");

                if (cityPart.Contains("|_"))
                {
                    cityPart = cityPart.Remove(cityPart.IndexOf("|"));
                }
                cityPart += $"|_{code}";

                return new ZipCityData()
                {
                    ZipCode = zipPart,
                    City = cityPart
                };
            };

            string[] listValues = lstUpdate.Items.Cast<String>().ToArray();
            var zipCityDataList = listValues.Select(zc => GetZipCityData(zc, specialCode)).ToList();
            using (ServiceClient.GeoAdminService proxy = new ServiceClient.GeoAdminService())
            {
                proxy.ClientCredentials.UserName.UserName = txtUserName.Text;
                proxy.ClientCredentials.UserName.Password = txtPassword.Text;
                proxy.UpdateZipCity(zipCityDataList);
            }
            btnGetZipCodes_Click(this, null);
        }

        private void btnUpdateSingleCity_Click(object sender, EventArgs e)
        {
            string selectedCityZip = lstUpdate.GetItemText(lstUpdate.SelectedItem);

            Func<string, string> extractZip = (text) => text.Substring(0, text.IndexOf("--"));

            Func<string, string, string>  extractCity = (string zipCityText, string specialCode) =>
             {
                 var c = zipCityText.Substring(zipCityText.IndexOf("--"), zipCityText.Length - zipCityText.IndexOf("--"))
                        .Replace("--", "");
                 return $"{c.Remove(c.Length - 4)}{specialCode}";
             };

            var zip = extractZip(selectedCityZip);
            var city = extractCity(selectedCityZip, txtPOCode.Text);

            using (ServiceClient.GeoAdminService proxy = new ServiceClient.GeoAdminService())
            {
                proxy.ClientCredentials.UserName.UserName = txtUserName.Text;
                proxy.ClientCredentials.UserName.Password = txtPassword.Text;
                proxy.UpdateZipCity(zip, city);
            }
            btnGetZipCodes_Click(this, null);
        }

        private void txtPOCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPOCode_TextChanged(object sender, EventArgs e)
        {
            txtPOCode.Text = txtPOCode.Text.ToUpper();
            txtPOCode.SelectionStart = txtPOCode.Text.Length;
            btnUpdateCityBatch.Enabled = txtPOCode.Text.Length == 4 && lstUpdate.Items.Count > 0;
            btnUpdateSingleCity.Enabled = txtPOCode.Text.Length == 4 && lstUpdate.Items.Count > 0;
        }

        private void btnUpdateCityBatch_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackColor = btn.Enabled ? Color.Black : Color.Silver;
        }

        private void btnUpdateSingleCity_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackColor = btn.Enabled ? Color.Black : Color.Silver;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnUpdateCityBatch.Enabled = false;
            btnUpdateSingleCity.Enabled = false;
        }

        private void btnGetStateCode_Click(object sender, EventArgs e)
        {
            using (ServiceClient.GeoService proxy = new ServiceClient.GeoService())
            {
                proxy.ClientCredentials.UserName.UserName = txtUserName.Text;
                proxy.ClientCredentials.UserName.Password = txtPassword.Text;
                StateCodeData scd = proxy.GetStateCode("CA");
                //Display this
            }
        }

        private void btnGetStatesCodes_Click(object sender, EventArgs e)
        {
            lstStates.Items.Clear();
            using (ServiceClient.GeoService proxy = new ServiceClient.GeoService())
            {
                proxy.ClientCredentials.UserName.UserName = txtUserName.Text;
                proxy.ClientCredentials.UserName.Password = txtPassword.Text;
                List<StateCodeData> scd = proxy.GetStatesCodes(true).ToList();
                lstStates.Columns.Add("SS Code", 100);
                lstStates.Columns.Add("Name", 100);
                lstStates.Columns.Add("Abbreviation", 100);
                lstStates.Columns.Add("State ID", 100);

                scd.ForEach(s =>
                {
                    var row = new string[4];
                    row[0] = s.SSCode;
                    row[1] = s.Name;
                    row[2] = s.Abbreviation;
                    row[3] = s.StateId.ToString();

                    var item = new ListViewItem(row);
                    lstStates.Items.Add(item);
                });
            }
        }

        private void btnUpdateByBatch_Click(object sender, EventArgs e)
        {
            lblFault.Text = string.Empty;
            try
            {
                using (ServiceClient.GeoAdminService proxy = new ServiceClient.GeoAdminService())
                {
                    proxy.ClientCredentials.UserName.UserName = txtUserName.Text;
                    proxy.ClientCredentials.UserName.Password = txtPassword.Text;

                    List<StateCodeData> stateCodeData = new List<StateCodeData>();
                    foreach (ListViewItem item in lstStates.Items)
                    {
                        StateCodeData scd = new StateCodeData()
                        {
                            SSCode = item.SubItems[0].Text,
                            Name = item.SubItems[1].Text,
                            Abbreviation = item.SubItems[2].Text,
                            StateId = int.Parse(item.SubItems[3].Text)
                        };

                        stateCodeData.Add(scd);
                    }
                    proxy.UpdateStateCodeBatch(stateCodeData);
                    btnGetStatesCodes_Click(this, null);
                }
            }
            catch (FaultException<GeoDatabaseUpdateFault> fex)
            {
                lblFault.Text = $"Exception Type: {fex.GetType()}\r\nIssue: {fex.Detail.Issue}\r\nIssue Detail: {fex.Detail.IssueDetail}\r\nReason: {fex.Reason}";
            }

            catch (FaultException<ApplicationException> fex)
            {
                lblFault.Text = $"Exception Type: {fex.GetType()}\r\nMessage: {fex.Message}\r\nReason: {fex.Reason}\r\nDetail: {fex.Detail}";
            }
        }
    }
}
