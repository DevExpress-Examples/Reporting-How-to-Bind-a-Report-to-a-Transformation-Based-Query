using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region usings
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
#endregion
#region usings_json
using DevExpress.DataAccess.Json;
#endregion
#region usings_federation
using DevExpress.DataAccess.DataFederation;
#endregion

namespace TransformationBasedQuery {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            #region CreateJsonDataSource
            // Create a JSON data source.
            JsonDataSource jsonDataSource = new JsonDataSource();
            Uri fileUri = new Uri("Products.json", UriKind.RelativeOrAbsolute);
            jsonDataSource.JsonSource = new UriJsonSource(fileUri);
            jsonDataSource.Fill();
            #endregion
            #region CreateFederationDataSource
            // Create a Federation data source.
            FederationDataSource federationDataSource = new FederationDataSource();
            Source jsonSource = new Source("json", jsonDataSource);
            TransformationNode query = jsonSource
                .Transform()
                .TransformColumn("Products")
                .Build("Transformation");
            federationDataSource.Queries.Add(query);
            #endregion
            #region CreateReport
            // Create a report and bind it to the Federation data source.
            XtraReport1 report = new XtraReport1();
            report.DataSource = federationDataSource;
            report.DataMember = "Transformation";
            #endregion
            #region DisplayReport
            // Display the report in the Document Viewer.
            documentViewer1.DocumentSource = report;
            #endregion
        }

        private void documentViewer1_Load(object sender, EventArgs e) {

        }
    }
}