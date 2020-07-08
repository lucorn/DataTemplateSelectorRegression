using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataTemplateSelectorRegression
{
    public class Item
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public bool LeftItem { get; set; }

        public Item(string title, string subtitle, bool leftItem)
        {
            Title = title;
            Subtitle = subtitle;
            LeftItem = leftItem;
        }
    }
    public class ItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate LeftTemplate { get; set; }

        public DataTemplate RightTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Item discussionItem = (Item)item;

            return (discussionItem.LeftItem) ? LeftTemplate : RightTemplate;
        }
    }

    public class MainViewModel
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainViewModel()
        {
            Items = new ObservableCollection<Item>();
        }
    }

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private MainViewModel _viewModel;
        
        public MainPage()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();

            BindingContext = _viewModel;

            _viewModel.Items.Add(new Item("hi there", "right now", true));
            _viewModel.Items.Add(new Item("common", "right now", true));
            _viewModel.Items.Add(new Item("do this right", "right now", false));
            _viewModel.Items.Add(new Item("one more time", "right now", true));
            _viewModel.Items.Add(new Item("I wish this would repro the problem", "right now", true));
            _viewModel.Items.Add(new Item("but maybe not this fast", "right now", false));
            _viewModel.Items.Add(new Item("one would hope. looking forward to it!", "right now", false));
            _viewModel.Items.Add(new Item("some of us are going to try", "right now", true));
            _viewModel.Items.Add(new Item("wish for a good outcome!", "right now", false));
            _viewModel.Items.Add(new Item("of course!", "right now", true));
            _viewModel.Items.Add(new Item("why not", "right now", false));
            _viewModel.Items.Add(new Item("worked just fine in Forms 4.5", "right now", false));
            _viewModel.Items.Add(new Item("yeah, recent regression!", "right now", true));
            _viewModel.Items.Add(new Item("possibly", "right now", false));

            _viewModel.Items.Add(new Item("some may like it", "right now", false));
            _viewModel.Items.Add(new Item("and others may not", "right now", false));
            _viewModel.Items.Add(new Item("is the issue caused by the scrolling?", "right now", false));

            var lastItem = new Item("this is the last item", "right now", false);

            _viewModel.Items.Add(lastItem);

            //itemsList.ScrollTo(lastItem, ScrollToPosition.End, false);
        }
    }
}
