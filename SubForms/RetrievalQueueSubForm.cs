using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.RetrievalWidgets;

namespace Valet_Parking_System.SubForms
{
    public partial class RetrievalQueueSubForm : UserControl
    {
        public List<RetrievalQueueItem> loadedQueueItems;
        private RetrievalTable table;
        public RetrievalQueueSubForm()
        {
            InitializeComponent();
            loadedQueueItems = new List<RetrievalQueueItem>();
            table = this.retrievalTable;
        }

        public void LoadQueueItems(List<RetrievalQueueItem> Items) 
        {          
            loadedQueueItems = Items;               
            Debug.WriteLine($"QueueItems count: {Items.Count}");
            table.DisplayQueueItems(loadedQueueItems); 
        }
    }
}
