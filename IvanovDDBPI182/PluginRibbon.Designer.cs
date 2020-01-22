namespace IvanovDDBPI182
{
    partial class PluginRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public PluginRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginRibbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.LayersMenu = this.Factory.CreateRibbonGroup();
            this.GroupsMenu = this.Factory.CreateRibbonGroup();
            this.CopiesMenu = this.Factory.CreateRibbonGroup();
            this.ImagesMenu = this.Factory.CreateRibbonGroup();
            this.AddLayerButton = this.Factory.CreateRibbonButton();
            this.ShowLayersButton = this.Factory.CreateRibbonButton();
            this.GroupManagerButton = this.Factory.CreateRibbonButton();
            this.SearchCopiesButton = this.Factory.CreateRibbonButton();
            this.SimilarsActionsMenu = this.Factory.CreateRibbonMenu();
            this.ApplyStyleForAllSimiliarsButton = this.Factory.CreateRibbonButton();
            this.ApplyStyleForSimiliarsThisSlideButton = this.Factory.CreateRibbonButton();
            this.PasteImageWithLinkButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.LayersMenu.SuspendLayout();
            this.GroupsMenu.SuspendLayout();
            this.CopiesMenu.SuspendLayout();
            this.ImagesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.LayersMenu);
            this.tab1.Groups.Add(this.GroupsMenu);
            this.tab1.Groups.Add(this.CopiesMenu);
            this.tab1.Groups.Add(this.ImagesMenu);
            this.tab1.Label = "Плагин";
            this.tab1.Name = "tab1";
            // 
            // LayersMenu
            // 
            this.LayersMenu.Items.Add(this.AddLayerButton);
            this.LayersMenu.Items.Add(this.ShowLayersButton);
            this.LayersMenu.Label = "Слои";
            this.LayersMenu.Name = "LayersMenu";
            // 
            // GroupsMenu
            // 
            this.GroupsMenu.Items.Add(this.GroupManagerButton);
            this.GroupsMenu.Label = "Группы";
            this.GroupsMenu.Name = "GroupsMenu";
            // 
            // CopiesMenu
            // 
            this.CopiesMenu.Items.Add(this.SearchCopiesButton);
            this.CopiesMenu.Items.Add(this.SimilarsActionsMenu);
            this.CopiesMenu.Label = "Копии";
            this.CopiesMenu.Name = "CopiesMenu";
            // 
            // ImagesMenu
            // 
            this.ImagesMenu.Items.Add(this.PasteImageWithLinkButton);
            this.ImagesMenu.Label = "Изображения";
            this.ImagesMenu.Name = "ImagesMenu";
            // 
            // AddLayerButton
            // 
            this.AddLayerButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AddLayerButton.Description = "Добавить слой из выбранных элементов";
            this.AddLayerButton.Image = ((System.Drawing.Image)(resources.GetObject("AddLayerButton.Image")));
            this.AddLayerButton.Label = "Добавить слой";
            this.AddLayerButton.Name = "AddLayerButton";
            this.AddLayerButton.ScreenTip = "Добавить слой из выбранных элементов";
            this.AddLayerButton.ShowImage = true;
            this.AddLayerButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddLayerButton_Click);
            // 
            // ShowLayersButton
            // 
            this.ShowLayersButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ShowLayersButton.Description = "Открыть менеджер слоёв";
            this.ShowLayersButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowLayersButton.Image")));
            this.ShowLayersButton.Label = "Менеджер слоёв";
            this.ShowLayersButton.Name = "ShowLayersButton";
            this.ShowLayersButton.ShowImage = true;
            this.ShowLayersButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ShowLayersButton_Click);
            // 
            // GroupManagerButton
            // 
            this.GroupManagerButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.GroupManagerButton.Image = ((System.Drawing.Image)(resources.GetObject("GroupManagerButton.Image")));
            this.GroupManagerButton.Label = "Меню групп";
            this.GroupManagerButton.Name = "GroupManagerButton";
            this.GroupManagerButton.ShowImage = true;
            this.GroupManagerButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GroupManagerButton_Click);
            // 
            // SearchCopiesButton
            // 
            this.SearchCopiesButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SearchCopiesButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchCopiesButton.Image")));
            this.SearchCopiesButton.Label = "Поиск копий";
            this.SearchCopiesButton.Name = "SearchCopiesButton";
            this.SearchCopiesButton.ShowImage = true;
            this.SearchCopiesButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SearchCopiesButton_Click);
            // 
            // SimilarsActionsMenu
            // 
            this.SimilarsActionsMenu.Items.Add(this.ApplyStyleForAllSimiliarsButton);
            this.SimilarsActionsMenu.Items.Add(this.ApplyStyleForSimiliarsThisSlideButton);
            this.SimilarsActionsMenu.Label = "Похожие элементы";
            this.SimilarsActionsMenu.Name = "SimilarsActionsMenu";
            // 
            // ApplyStyleForAllSimiliarsButton
            // 
            this.ApplyStyleForAllSimiliarsButton.Description = "Найти похожие элементы такого же стиля во всей презентации и изменить";
            this.ApplyStyleForAllSimiliarsButton.Label = "Найти все похожие по стилю элементы";
            this.ApplyStyleForAllSimiliarsButton.Name = "ApplyStyleForAllSimiliarsButton";
            this.ApplyStyleForAllSimiliarsButton.ShowImage = true;
            this.ApplyStyleForAllSimiliarsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ApplyStyleForAllSimiliarsButton_Click);
            // 
            // ApplyStyleForSimiliarsThisSlideButton
            // 
            this.ApplyStyleForSimiliarsThisSlideButton.Label = "Найти похожие элементы на этом слайде";
            this.ApplyStyleForSimiliarsThisSlideButton.Name = "ApplyStyleForSimiliarsThisSlideButton";
            this.ApplyStyleForSimiliarsThisSlideButton.ShowImage = true;
            this.ApplyStyleForSimiliarsThisSlideButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ApplyStyleForSimiliarsThisSlideButton_Click);
            // 
            // PasteImageWithLinkButton
            // 
            this.PasteImageWithLinkButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.PasteImageWithLinkButton.Description = "Вставить картинку из буфера обмена с подписью";
            this.PasteImageWithLinkButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteImageWithLinkButton.Image")));
            this.PasteImageWithLinkButton.Label = "Вставка рисунка по URL";
            this.PasteImageWithLinkButton.Name = "PasteImageWithLinkButton";
            this.PasteImageWithLinkButton.ShowImage = true;
            this.PasteImageWithLinkButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PasteImageWithLinkButton_Click);
            // 
            // PluginRibbon
            // 
            this.Name = "PluginRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.PluginRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.LayersMenu.ResumeLayout(false);
            this.LayersMenu.PerformLayout();
            this.GroupsMenu.ResumeLayout(false);
            this.GroupsMenu.PerformLayout();
            this.CopiesMenu.ResumeLayout(false);
            this.CopiesMenu.PerformLayout();
            this.ImagesMenu.ResumeLayout(false);
            this.ImagesMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ImagesMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup LayersMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton PasteImageWithLinkButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ShowLayersButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AddLayerButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupsMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup CopiesMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SearchCopiesButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton GroupManagerButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu SimilarsActionsMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ApplyStyleForAllSimiliarsButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ApplyStyleForSimiliarsThisSlideButton;
    }

    partial class ThisRibbonCollection
    {
        internal PluginRibbon Ribbon1
        {
            get { return this.GetRibbon<PluginRibbon>(); }
        }
    }
}
