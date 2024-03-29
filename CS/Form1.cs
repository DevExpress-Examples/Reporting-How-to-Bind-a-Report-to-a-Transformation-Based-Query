using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Json;
using DevExpress.DataAccess.DataFederation;

namespace TransformationBasedQuery {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // Create a JSON data source.
            JsonDataSource jsonDataSource = new JsonDataSource();
            Uri fileUri = new Uri("Products.json", UriKind.RelativeOrAbsolute);
            jsonDataSource.JsonSource = new UriJsonSource(fileUri);
            jsonDataSource.Fill();
            // Create a Federation data source.
            FederationDataSource federationDataSource = new FederationDataSource();
            Source jsonSource = new Source("json", jsonDataSource);
            TransformationNode query = jsonSource
                .Transform()
                .TransformColumn("Products")
                .Build("Transformation");
            federationDataSource.Queries.Add(query);
            // Create a report and bind it to the Federation data source.
            XtraReport1 report = new XtraReport1();
            report.DataSource = federationDataSource;
            report.DataMember = "Transformation";
            // Display the report in the Document Viewer.
            documentViewer1.DocumentSource = report;
        }

        private void documentViewer1_Load(object sender, EventArgs e) {

        }
    }
}
