﻿[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v6.0", FrameworkDisplayName="")]
[assembly: System.Windows.Markup.XmlnsDefinition("http://schemas.wildgums.com/orc/controls", "Orc.Controls")]
[assembly: System.Windows.Markup.XmlnsDefinition("http://schemas.wildgums.com/orc/controls", "Orc.Controls.Converters")]
[assembly: System.Windows.Markup.XmlnsPrefix("http://schemas.wildgums.com/orc/controls", "orccontrols")]
[assembly: System.Windows.ThemeInfo(System.Windows.ResourceDictionaryLocation.None, System.Windows.ResourceDictionaryLocation.SourceAssembly)]
public static class LoadAssembliesOnStartup { }
public static class ModuleInitializer
{
    public static void Initialize() { }
}
namespace Orc.Automation
{
    public class CulturePickerAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.CulturePicker>
    {
        public CulturePickerAutomationPeer(Orc.Controls.CulturePicker culturePicker) { }
        [Orc.Automation.AutomationMethod]
        public System.Collections.Generic.List<System.Globalization.CultureInfo> GetAvailableCultures() { }
    }
    public class CulturePickerMap : Orc.Automation.AutomationBase
    {
        public CulturePickerMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.ComboBox Combobox { get; }
    }
    public class NumericUpDownAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.NumericUpDown>
    {
        public NumericUpDownAutomationPeer(Orc.Controls.NumericUpDown numericUpDown) { }
    }
    public class TabControlAutomationPeer : System.Windows.Automation.Peers.TabControlAutomationPeer
    {
        public TabControlAutomationPeer(System.Windows.Controls.TabControl owner) { }
        protected override System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore() { }
    }
}
namespace Orc.Controls
{
    public class AlignmentGrid : System.Windows.Controls.ContentControl
    {
        public static readonly System.Windows.DependencyProperty HorizontalStepProperty;
        public static readonly System.Windows.DependencyProperty LineBrushProperty;
        public static readonly System.Windows.DependencyProperty VerticalStepProperty;
        public AlignmentGrid() { }
        public double HorizontalStep { get; set; }
        public System.Windows.Media.Brush LineBrush { get; set; }
        public double VerticalStep { get; set; }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class AnimatedGif : System.Windows.Controls.Image
    {
        public static readonly System.Windows.DependencyProperty GifSourceProperty;
        public AnimatedGif() { }
        public string GifSource { get; set; }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class AnimatingTextBlock : System.Windows.Controls.UserControl, Orc.Controls.Services.IStatusRepresenter
    {
        public static readonly System.Windows.DependencyProperty HideStoryboardProperty;
        public static readonly System.Windows.DependencyProperty ShowStoryboardProperty;
        public static readonly System.Windows.DependencyProperty TextProperty;
        public AnimatingTextBlock() { }
        public System.Windows.Media.Animation.Storyboard HideStoryboard { get; set; }
        public System.Windows.Media.Animation.Storyboard ShowStoryboard { get; set; }
        public string Text { get; set; }
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        public void UpdateStatus(string status) { }
    }
    public class ApplicationLogFilterGroupService : Orc.Controls.IApplicationLogFilterGroupService
    {
        public ApplicationLogFilterGroupService(Orc.FileSystem.IFileService fileService, Catel.Runtime.Serialization.Xml.IXmlSerializer xmlSerializer) { }
        protected virtual System.Collections.Generic.List<Orc.Controls.LogFilterGroup> CreateRuntimeFilterGroups() { }
        public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Orc.Controls.LogFilterGroup>> LoadAsync() { }
        public System.Threading.Tasks.Task SaveAsync(System.Collections.Generic.IEnumerable<Orc.Controls.LogFilterGroup> filterGroups) { }
    }
    public class BindableRichTextBox : System.Windows.Controls.RichTextBox
    {
        public static readonly System.Windows.DependencyProperty AutoScrollToEndProperty;
        public static readonly System.Windows.DependencyProperty BindableDocumentProperty;
        public BindableRichTextBox() { }
        public bool AutoScrollToEnd { get; set; }
        public System.Windows.Documents.FlowDocument BindableDocument { get; set; }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class BindableRun : System.Windows.Documents.Run
    {
        public static readonly System.Windows.DependencyProperty BoundTextProperty;
        public BindableRun() { }
        public string BoundText { get; set; }
    }
    public class BusyIndicator : Orc.Controls.VisualWrapper, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty ForegroundProperty;
        public static readonly System.Windows.DependencyProperty IgnoreUnloadedEventCountProperty;
        public BusyIndicator() { }
        public System.Windows.Media.Brush Foreground { get; set; }
        public int IgnoreUnloadedEventCount { get; set; }
        public void InitializeComponent() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnRenderSizeChanged(System.Windows.SizeChangedInfo sizeInfo) { }
    }
    [System.Windows.Markup.ContentProperty("InnerContent")]
    public class Callout : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty CalloutNameProperty;
        public static readonly System.Windows.DependencyProperty CommandProperty;
        public static readonly System.Windows.DependencyProperty DescriptionProperty;
        public static readonly System.Windows.DependencyProperty HorizontalOffsetProperty;
        public static readonly System.Windows.DependencyProperty InnerContentProperty;
        public static readonly System.Windows.DependencyProperty IsClosableProperty;
        public static readonly System.Windows.DependencyProperty IsOpenProperty;
        public static readonly System.Windows.DependencyProperty PlacementProperty;
        public static readonly System.Windows.DependencyProperty PlacementTargetProperty;
        public static readonly System.Windows.DependencyProperty ShowTimeProperty;
        public static readonly System.Windows.DependencyProperty TailBaseWidthProperty;
        public static readonly System.Windows.DependencyProperty TailHorizontalAlignmentProperty;
        public static readonly System.Windows.DependencyProperty TailVerticalAlignmentProperty;
        public static readonly System.Windows.DependencyProperty TitleProperty;
        public static readonly System.Windows.DependencyProperty VerticalOffsetProperty;
        public Callout() { }
        [Catel.MVVM.Views.ViewToViewModel("Name", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string CalloutName { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public System.Windows.Input.ICommand Command { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string Description { get; set; }
        public double HorizontalOffset { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public object InnerContent { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool IsClosable { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool IsOpen { get; set; }
        public System.Windows.Controls.Primitives.PlacementMode Placement { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public object PlacementTarget { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public System.TimeSpan ShowTime { get; set; }
        public double TailBaseWidth { get; set; }
        public System.Windows.HorizontalAlignment TailHorizontalAlignment { get; set; }
        public System.Windows.VerticalAlignment TailVerticalAlignment { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string Title { get; set; }
        public double VerticalOffset { get; set; }
        public void InitializeComponent() { }
        protected override void OnLoaded(System.EventArgs e) { }
    }
    public class CalloutEventArgs : System.EventArgs
    {
        public CalloutEventArgs(Orc.Controls.ICallout callout) { }
        public Orc.Controls.ICallout Callout { get; }
    }
    public class CalloutManager : Orc.Controls.ICalloutManager
    {
        public CalloutManager() { }
        public System.Collections.Generic.List<Orc.Controls.ICallout> Callouts { get; }
        public bool IsSuspended { get; }
        public event System.EventHandler<Orc.Controls.CalloutEventArgs> Hiding;
        public event System.EventHandler<Orc.Controls.CalloutEventArgs> Registered;
        public event System.EventHandler<Orc.Controls.CalloutEventArgs> Showing;
        public event System.EventHandler<Orc.Controls.CalloutEventArgs> Unregistered;
        public void Clear() { }
        public void Register(Orc.Controls.ICallout callout) { }
        public void Resume() { }
        public void Suspend() { }
        public void Unregister(Orc.Controls.ICallout callout) { }
    }
    public class CalloutViewModel : Catel.MVVM.ViewModelBase, Orc.Controls.ICallout
    {
        public static readonly Catel.Data.IPropertyData DescriptionProperty;
        public static readonly Catel.Data.IPropertyData HasShownProperty;
        public static readonly Catel.Data.IPropertyData IdProperty;
        public static readonly Catel.Data.IPropertyData InnerContentProperty;
        public static readonly Catel.Data.IPropertyData IsClosableProperty;
        public static readonly Catel.Data.IPropertyData IsOpenProperty;
        public static readonly Catel.Data.IPropertyData NameProperty;
        public static readonly Catel.Data.IPropertyData PlacementTargetProperty;
        public static readonly Catel.Data.IPropertyData ShowTimeProperty;
        public static readonly Catel.Data.IPropertyData VersionProperty;
        public CalloutViewModel(Orc.Controls.ICalloutManager calloutManager, Catel.Services.IDispatcherService dispatcherService) { }
        public Catel.MVVM.Command ClosePopup { get; }
        public System.Windows.Input.ICommand Command { get; set; }
        public string Description { get; set; }
        public bool HasShown { get; }
        public System.Guid Id { get; }
        public object InnerContent { get; set; }
        public bool IsClosable { get; set; }
        public bool IsOpen { get; set; }
        public string Name { get; set; }
        public Catel.MVVM.Command PauseTimer { get; }
        public System.Windows.UIElement PlacementTarget { get; set; }
        public Catel.MVVM.Command ResumeTimer { get; }
        public System.TimeSpan ShowTime { get; set; }
        public object Tag { get; }
        public new string Title { get; set; }
        public string Version { get; set; }
        public event System.EventHandler<Orc.Controls.CalloutEventArgs> Hiding;
        public event System.EventHandler<Orc.Controls.CalloutEventArgs> Showing;
        protected override System.Threading.Tasks.Task CloseAsync() { }
        public void Hide() { }
        protected override System.Threading.Tasks.Task InitializeAsync() { }
        public void Show() { }
        public override string ToString() { }
    }
    public abstract class CalloutWatcherBase
    {
        protected readonly Orc.Controls.ICalloutManager _calloutManager;
        protected readonly Catel.Configuration.IConfigurationService _configurationService;
        public CalloutWatcherBase(Orc.Controls.ICalloutManager calloutManager, Catel.Configuration.IConfigurationService configurationService) { }
        public virtual Orc.Controls.ICallout Callout { get; }
        public bool HasShown { get; }
        public System.Guid? Id { get; set; }
        public bool IsOneTimeCallout { get; set; }
        public string Name { get; set; }
        public System.TimeSpan ShowInterval { get; set; }
        public virtual string Version { get; }
        protected virtual System.Threading.Tasks.Task<System.DateTime?> GetLastShownUtcAsync() { }
        protected virtual void Hide() { }
        protected virtual System.Threading.Tasks.Task ShowAsync() { }
    }
    [System.Windows.TemplatePart(Name="PART_A0GradientStop", Type=typeof(System.Windows.Media.GradientStop))]
    [System.Windows.TemplatePart(Name="PART_A1GradientStop", Type=typeof(System.Windows.Media.GradientStop))]
    [System.Windows.TemplatePart(Name="PART_ASlider", Type=typeof(System.Windows.Controls.Slider))]
    [System.Windows.TemplatePart(Name="PART_ATextBox", Type=typeof(System.Windows.Controls.TextBox))]
    [System.Windows.TemplatePart(Name="PART_B0GradientStop", Type=typeof(System.Windows.Media.GradientStop))]
    [System.Windows.TemplatePart(Name="PART_B1GradientStop", Type=typeof(System.Windows.Media.GradientStop))]
    [System.Windows.TemplatePart(Name="PART_BSlider", Type=typeof(System.Windows.Controls.Slider))]
    [System.Windows.TemplatePart(Name="PART_BTextBox", Type=typeof(System.Windows.Controls.TextBox))]
    [System.Windows.TemplatePart(Name="PART_CancelButton", Type=typeof(System.Windows.Controls.Button))]
    [System.Windows.TemplatePart(Name="PART_ColorBrush", Type=typeof(System.Windows.Media.SolidColorBrush))]
    [System.Windows.TemplatePart(Name="PART_ColorComboBox", Type=typeof(System.Windows.Controls.ComboBox))]
    [System.Windows.TemplatePart(Name="PART_ColorTextBox", Type=typeof(System.Windows.Controls.TextBox))]
    [System.Windows.TemplatePart(Name="PART_G0GradientStop", Type=typeof(System.Windows.Media.GradientStop))]
    [System.Windows.TemplatePart(Name="PART_G1GradientStop", Type=typeof(System.Windows.Media.GradientStop))]
    [System.Windows.TemplatePart(Name="PART_GSlider", Type=typeof(System.Windows.Controls.Slider))]
    [System.Windows.TemplatePart(Name="PART_GTextBox", Type=typeof(System.Windows.Controls.TextBox))]
    [System.Windows.TemplatePart(Name="PART_HSVCanvas", Type=typeof(System.Windows.Controls.Canvas))]
    [System.Windows.TemplatePart(Name="PART_HSVColorGradientStop", Type=typeof(System.Windows.Media.GradientStop))]
    [System.Windows.TemplatePart(Name="PART_HSVEllipse", Type=typeof(System.Windows.Shapes.Ellipse))]
    [System.Windows.TemplatePart(Name="PART_HSVRectangle", Type=typeof(System.Windows.Shapes.Rectangle))]
    [System.Windows.TemplatePart(Name="PART_HSVSlider", Type=typeof(System.Windows.Controls.Slider))]
    [System.Windows.TemplatePart(Name="PART_R0GradientStop", Type=typeof(System.Windows.Media.GradientStop))]
    [System.Windows.TemplatePart(Name="PART_R1GradientStop", Type=typeof(System.Windows.Media.GradientStop))]
    [System.Windows.TemplatePart(Name="PART_RSlider", Type=typeof(System.Windows.Controls.Slider))]
    [System.Windows.TemplatePart(Name="PART_RTextBox", Type=typeof(System.Windows.Controls.TextBox))]
    [System.Windows.TemplatePart(Name="PART_RecentColorsListBox", Type=typeof(System.Windows.Controls.ListBox))]
    [System.Windows.TemplatePart(Name="PART_RootGrid", Type=typeof(System.Windows.FrameworkElement))]
    [System.Windows.TemplatePart(Name="PART_SelectButton", Type=typeof(System.Windows.Controls.Button))]
    [System.Windows.TemplatePart(Name="PART_ThemeColorsListBox", Type=typeof(System.Windows.Controls.ListBox))]
    public class ColorBoard : System.Windows.Controls.Control
    {
        public static readonly System.Windows.RoutedEvent CancelClickedEvent;
        public static readonly System.Windows.DependencyProperty ColorProperty;
        public static readonly System.Windows.RoutedEvent DoneClickedEvent;
        public static readonly System.Windows.DependencyProperty RecentColorItemsProperty;
        public ColorBoard() { }
        public System.Windows.Media.Color Color { get; set; }
        public System.Collections.Generic.List<Orc.Controls.PredefinedColorItem> RecentColorItems { get; set; }
        public event System.Windows.RoutedEventHandler CancelClicked;
        public event System.Windows.RoutedEventHandler DoneClicked;
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        public void OnDoneClicked() { }
        public void SetHsvColor(System.Windows.Media.Color color) { }
    }
    public class ColorChangedEventArgs : System.EventArgs
    {
        public ColorChangedEventArgs(System.Windows.Media.Color newColor, System.Windows.Media.Color oldColor) { }
        public System.Windows.Media.Color NewColor { get; set; }
        public System.Windows.Media.Color OldColor { get; set; }
    }
    public static class ColorHelper
    {
        public static double GetHSB_B(System.Windows.Media.Color color) { }
        public static double GetHSB_H(System.Windows.Media.Color color) { }
        public static double GetHSB_S(System.Windows.Media.Color color) { }
        public static double GetHSV_H(System.Windows.Media.Color color) { }
        public static double GetHSV_S(System.Windows.Media.Color color) { }
        public static double GetHSV_V(System.Windows.Media.Color color) { }
        public static System.Windows.Media.Color HSB2RGB(double h, double s, double l) { }
        public static System.Windows.Media.Color HSV2RGB(double h, double s, double v) { }
    }
    [System.Windows.TemplatePart(Name="PART_All_Visible", Type=typeof(System.Windows.Controls.CheckBox))]
    [System.Windows.TemplatePart(Name="PART_List", Type=typeof(System.Windows.Controls.ListBox))]
    [System.Windows.TemplatePart(Name="PART_Popup_Color_Board", Type=typeof(System.Windows.Controls.Primitives.Popup))]
    [System.Windows.TemplatePart(Name="PART_Settings_Button", Type=typeof(Orc.Controls.DropDownButton))]
    [System.Windows.TemplatePart(Name="PART_UnselectAll", Type=typeof(System.Windows.Controls.Primitives.ButtonBase))]
    public class ColorLegend : System.Windows.Controls.HeaderedContentControl
    {
        public static readonly System.Windows.DependencyProperty AllowColorEditingProperty;
        public static readonly System.Windows.DependencyProperty EditingColorProperty;
        public static readonly System.Windows.DependencyProperty FilterProperty;
        public static readonly System.Windows.DependencyProperty FilterWatermarkProperty;
        public static readonly System.Windows.DependencyProperty FilteredItemsIdsProperty;
        public static readonly System.Windows.DependencyProperty FilteredItemsSourceProperty;
        public static readonly System.Windows.DependencyProperty IsAllVisibleProperty;
        public static readonly System.Windows.DependencyProperty IsColorSelectingProperty;
        public static readonly System.Windows.DependencyProperty ItemsSourceProperty;
        public static readonly System.Windows.DependencyProperty SelectedColorItemsProperty;
        public static readonly System.Windows.DependencyProperty ShowBottomToolBoxProperty;
        public static readonly System.Windows.DependencyProperty ShowColorPickerProperty;
        public static readonly System.Windows.DependencyProperty ShowColorVisibilityControlsProperty;
        public static readonly System.Windows.DependencyProperty ShowSearchBoxProperty;
        public static readonly System.Windows.DependencyProperty ShowSettingsBoxProperty;
        public static readonly System.Windows.DependencyProperty ShowToolBoxProperty;
        public ColorLegend() { }
        public bool AllowColorEditing { get; set; }
        public Catel.MVVM.Command<object> ChangeColor { get; }
        public System.Windows.Media.Color EditingColor { get; set; }
        public string Filter { get; set; }
        public string FilterWatermark { get; set; }
        public System.Collections.Generic.IEnumerable<string> FilteredItemsIds { get; set; }
        public System.Collections.Generic.IEnumerable<Orc.Controls.IColorLegendItem> FilteredItemsSource { get; set; }
        public bool? IsAllVisible { get; set; }
        public bool IsColorSelecting { get; set; }
        public System.Collections.Generic.IEnumerable<Orc.Controls.IColorLegendItem> ItemsSource { get; set; }
        public System.Collections.Generic.IEnumerable<Orc.Controls.IColorLegendItem> SelectedColorItems { get; set; }
        public bool ShowBottomToolBox { get; set; }
        public bool ShowColorPicker { get; set; }
        public bool ShowColorVisibilityControls { get; set; }
        public bool ShowSearchBox { get; set; }
        public bool ShowSettingsBox { get; set; }
        public bool ShowToolBox { get; set; }
        public event System.EventHandler<System.EventArgs> SelectionChanged;
        protected System.Collections.Generic.IEnumerable<Orc.Controls.IColorLegendItem> GetFilteredItems() { }
        public System.Collections.Generic.IEnumerable<Orc.Controls.IColorLegendItem> GetSelectedList() { }
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        public void SetSelectedList(System.Collections.Generic.IEnumerable<Orc.Controls.IColorLegendItem> selectedList) { }
        public void UpdateColorEditingControlsVisibility() { }
        public void UpdateColorPickerColorVisibility() { }
        public void UpdateVisibilityControlsVisibility() { }
    }
    [Catel.Runtime.Serialization.SerializerModifier(typeof(Orc.Controls.ColorLegendItemSerializerModifier))]
    [System.Runtime.Serialization.KnownType(typeof(System.Windows.Media.Color))]
    [System.Serializable]
    public class ColorLegendItem : Catel.Data.ModelBase, Orc.Controls.IColorLegendItem, System.ComponentModel.INotifyPropertyChanged
    {
        public static readonly Catel.Data.IPropertyData AdditionalDataProperty;
        public static readonly Catel.Data.IPropertyData ColorProperty;
        public static readonly Catel.Data.IPropertyData DescriptionProperty;
        public static readonly Catel.Data.IPropertyData IdProperty;
        public static readonly Catel.Data.IPropertyData IsCheckedProperty;
        public static readonly Catel.Data.IPropertyData IsSelectedProperty;
        public ColorLegendItem() { }
        public string AdditionalData { get; set; }
        [Catel.Runtime.Serialization.IncludeInSerialization]
        public System.Windows.Media.Color Color { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public bool IsChecked { get; set; }
        public bool IsSelected { get; set; }
    }
    public class ColorLegendItemSerializerModifier : Catel.Runtime.Serialization.SerializerModifierBase<Orc.Controls.ColorLegendItem>
    {
        public ColorLegendItemSerializerModifier() { }
        public override void DeserializeMember(Catel.Runtime.Serialization.ISerializationContext context, Catel.Runtime.Serialization.MemberValue memberValue) { }
        public override void SerializeMember(Catel.Runtime.Serialization.ISerializationContext context, Catel.Runtime.Serialization.MemberValue memberValue) { }
    }
    [System.Windows.TemplatePart(Name="PART_Popup", Type=typeof(System.Windows.Controls.Primitives.Popup))]
    public class ColorPicker : System.Windows.Controls.Control
    {
        public static readonly System.Windows.DependencyProperty ColorProperty;
        public static readonly System.Windows.DependencyProperty CurrentColorProperty;
        public static readonly System.Windows.DependencyProperty IsDropDownOpenProperty;
        public static readonly System.Windows.DependencyProperty PopupPlacementProperty;
        public ColorPicker() { }
        public System.Windows.Media.Color Color { get; set; }
        public System.Windows.Media.Color CurrentColor { get; set; }
        public bool IsDropDownOpen { get; set; }
        public System.Windows.Controls.Primitives.PlacementMode PopupPlacement { get; set; }
        public event System.EventHandler<Orc.Controls.ColorChangedEventArgs> ColorChanged;
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class ComboboxEditableControlBehavior : Orc.Controls.EditableControlBehaviorBase<System.Windows.Controls.ComboBox>
    {
        public ComboboxEditableControlBehavior() { }
        protected override void OnAssociatedObjectLoaded() { }
        protected override void OnAssociatedObjectUnloaded() { }
    }
    public abstract class ControlToolBase : Catel.Data.ModelBase, Orc.Controls.IControlTool
    {
        protected object Target;
        public static readonly Catel.Data.IPropertyData IsOpenedProperty;
        protected ControlToolBase() { }
        public virtual bool IsEnabled { get; }
        public bool IsOpened { get; }
        public abstract string Name { get; }
        public event System.EventHandler<System.EventArgs> Attached;
        public event System.EventHandler<System.EventArgs> Closed;
        public event System.EventHandler<System.EventArgs> Detached;
        public event System.EventHandler<System.EventArgs> Opened;
        public event System.EventHandler<System.EventArgs> Opening;
        public virtual void Attach(object target) { }
        public virtual void Close() { }
        public virtual void Detach() { }
        protected virtual void OnAddParameter(object parameter) { }
        protected abstract void OnOpen(object parameter = null);
        public void Open(object parameter = null) { }
    }
    public sealed class CulturePicker : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty SelectedCultureProperty;
        public CulturePicker() { }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public System.Globalization.CultureInfo SelectedCulture { get; set; }
        public void InitializeComponent() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    [System.Obsolete("Use DateTimePicker instead. Will be removed in version 5.0.0.", true)]
    [System.Windows.TemplatePart(Name="PART_ClearButton", Type=typeof(System.Windows.Controls.Button))]
    [System.Windows.TemplatePart(Name="PART_CopyButton", Type=typeof(System.Windows.Controls.Button))]
    [System.Windows.TemplatePart(Name="PART_DatePickerIconToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    [System.Windows.TemplatePart(Name="PART_DaysMonthsSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_DaysNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_DaysToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    [System.Windows.TemplatePart(Name="PART_MainGrid", Type=typeof(System.Windows.Controls.Grid))]
    [System.Windows.TemplatePart(Name="PART_MonthNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_MonthToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    [System.Windows.TemplatePart(Name="PART_MonthsYearSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_PasteButton", Type=typeof(System.Windows.Controls.Button))]
    [System.Windows.TemplatePart(Name="PART_SelectDateButton", Type=typeof(System.Windows.Controls.Button))]
    [System.Windows.TemplatePart(Name="PART_TodayButton", Type=typeof(System.Windows.Controls.Button))]
    [System.Windows.TemplatePart(Name="PART_YearNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_YearSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_YearToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    public class DatePicker : System.Windows.Controls.Control
    {
        public static readonly System.Windows.DependencyProperty AllowCopyPasteProperty;
        public static readonly System.Windows.DependencyProperty AllowNullProperty;
        public static readonly System.Windows.DependencyProperty FormatProperty;
        public static readonly System.Windows.DependencyProperty IsReadOnlyProperty;
        public static readonly System.Windows.DependencyProperty IsYearShortFormatProperty;
        public static readonly System.Windows.DependencyProperty ShowOptionsButtonProperty;
        public static readonly System.Windows.DependencyProperty ValueProperty;
        public DatePicker() { }
        public bool AllowCopyPaste { get; set; }
        public bool AllowNull { get; set; }
        public string Format { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsYearShortFormat { get; }
        public bool ShowOptionsButton { get; set; }
        public System.DateTime? Value { get; set; }
        public override void OnApplyTemplate() { }
    }
    public class DateRange : Catel.Data.ModelBase
    {
        public static readonly Catel.Data.IPropertyData EndProperty;
        public static readonly Catel.Data.IPropertyData IsTemporaryProperty;
        public static readonly Catel.Data.IPropertyData NameProperty;
        public static readonly Catel.Data.IPropertyData StartProperty;
        public DateRange() { }
        public System.TimeSpan Duration { get; }
        public System.DateTime End { get; set; }
        public bool IsTemporary { get; }
        public string Name { get; set; }
        public System.DateTime Start { get; set; }
        protected override void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
        public override string ToString() { }
    }
    public class DateRangePicker : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty AllowCopyPasteProperty;
        public static readonly System.Windows.DependencyProperty EndDateProperty;
        public static readonly System.Windows.DependencyProperty FormatProperty;
        public static readonly System.Windows.DependencyProperty HideSecondsProperty;
        public static readonly System.Windows.DependencyProperty HideTimeProperty;
        public static readonly System.Windows.DependencyProperty IsAdvancedModeProperty;
        public static readonly System.Windows.DependencyProperty IsReadOnlyProperty;
        public static readonly System.Windows.DependencyProperty RangesProperty;
        public static readonly System.Windows.DependencyProperty SelectedRangeProperty;
        public static readonly System.Windows.DependencyProperty ShowOptionsButtonProperty;
        public static readonly System.Windows.DependencyProperty SpanProperty;
        public static readonly System.Windows.DependencyProperty StartDateProperty;
        public DateRangePicker() { }
        public bool AllowCopyPaste { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public System.DateTime EndDate { get; set; }
        public string Format { get; set; }
        public bool HideSeconds { get; set; }
        public bool HideTime { get; set; }
        public bool IsAdvancedMode { get; set; }
        public bool IsReadOnly { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public System.Collections.ObjectModel.ObservableCollection<Orc.Controls.DateRange> Ranges { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public Orc.Controls.DateRange SelectedRange { get; set; }
        public bool ShowOptionsButton { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public System.TimeSpan Span { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public System.DateTime StartDate { get; set; }
        public void InitializeComponent() { }
    }
    public class DateRangePickerViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData TimeAdjustmentStrategyProperty;
        public DateRangePickerViewModel() { }
        public System.DateTime EndDate { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<Orc.Controls.DateRange> Ranges { get; set; }
        public Orc.Controls.DateRange SelectedRange { get; set; }
        public System.TimeSpan Span { get; set; }
        public System.DateTime StartDate { get; set; }
        public Orc.Controls.TimeAdjustmentStrategy TimeAdjustmentStrategy { get; set; }
        protected override void OnValidating(Catel.Data.IValidationContext validationContext) { }
    }
    public static class DateTimeFormatHelper
    {
        public static string ExtractDatePatternFromFormat(string format) { }
        public static string ExtractTimePatternFromFormat(string format) { }
        public static string FindMatchedLongTimePattern(System.Globalization.CultureInfo cultureInfo, string timePattern) { }
        public static string FixFormat(System.Globalization.CultureInfo culture, string format, out bool hadAnyTimeFormat) { }
        public static Orc.Controls.DateTimeFormatInfo GetDateTimeFormatInfo(string format, bool isDateOnly = false, bool throwException = true) { }
        public static string[] Split(string format, char[] formatCharacters) { }
    }
    public class DateTimeFormatInfo
    {
        public DateTimeFormatInfo() { }
        public string AmPmFormat { get; set; }
        public int? AmPmPosition { get; set; }
        public string DayFormat { get; set; }
        public int DayPosition { get; set; }
        public string HourFormat { get; set; }
        public int? HourPosition { get; set; }
        public bool? IsAmPmShortFormat { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsDateOnly { get; }
        public bool? IsHour12Format { get; set; }
        public bool IsYearShortFormat { get; set; }
        public int MaxPosition { get; set; }
        public string MinuteFormat { get; set; }
        public int? MinutePosition { get; set; }
        public string MonthFormat { get; set; }
        public int MonthPosition { get; set; }
        public string SecondFormat { get; set; }
        public int? SecondPosition { get; set; }
        public string Separator0 { get; set; }
        public string Separator1 { get; set; }
        public string Separator2 { get; set; }
        public string Separator3 { get; set; }
        public string Separator4 { get; set; }
        public string Separator5 { get; set; }
        public string Separator6 { get; set; }
        public string Separator7 { get; set; }
        public string YearFormat { get; set; }
        public int YearPosition { get; set; }
        public string GetSeparator(int position) { }
    }
    public static class DateTimeFormatter
    {
        public static string Format(System.DateTime dateTime, string format, bool isDateOnly = false) { }
    }
    public static class DateTimeParser
    {
        public static System.DateTime Parse(string input, string format, bool isDateOnly = false) { }
        public static bool TryParse(string input, string format, out System.DateTime dateTime, bool isDateOnly = false) { }
    }
    public enum DateTimePart
    {
        Day = 0,
        Month = 1,
        Year = 2,
        Hour = 3,
        Hour12 = 4,
        Minute = 5,
        Second = 6,
        AmPmDesignator = 7,
    }
    public class DateTimePartHelper
    {
        public DateTimePartHelper(System.DateTime dateTime, Orc.Controls.DateTimePart dateTimePart, Orc.Controls.DateTimeFormatInfo dateTimeFormatInfo, System.Windows.Controls.TextBox textBox, System.Windows.Controls.Primitives.ToggleButton activeToggleButton) { }
        public System.Windows.Controls.Primitives.Popup CreatePopup() { }
    }
    [System.Windows.TemplatePart(Name="PART_AmPmListTextBox", Type=typeof(Orc.Controls.ListTextBox))]
    [System.Windows.TemplatePart(Name="PART_AmPmSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_AmPmToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    [System.Windows.TemplatePart(Name="PART_Calendar", Type=typeof(System.Windows.Controls.Calendar))]
    [System.Windows.TemplatePart(Name="PART_CalendarPopup", Type=typeof(System.Windows.Controls.Primitives.Popup))]
    [System.Windows.TemplatePart(Name="PART_ClearMenuItem", Type=typeof(System.Windows.Controls.MenuItem))]
    [System.Windows.TemplatePart(Name="PART_CopyMenuItem", Type=typeof(System.Windows.Controls.MenuItem))]
    [System.Windows.TemplatePart(Name="PART_DatePickerIconDropDownButton", Type=typeof(Orc.Controls.DropDownButton))]
    [System.Windows.TemplatePart(Name="PART_DaysMonthsSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_DaysNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_DaysToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    [System.Windows.TemplatePart(Name="PART_HourMinuteSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_HourNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_HourToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    [System.Windows.TemplatePart(Name="PART_MainGrid", Type=typeof(System.Windows.Controls.Grid))]
    [System.Windows.TemplatePart(Name="PART_MinuteNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_MinuteSecondSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_MinuteToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    [System.Windows.TemplatePart(Name="PART_MonthNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_MonthToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    [System.Windows.TemplatePart(Name="PART_MonthsYearSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_NowMenuItem", Type=typeof(System.Windows.Controls.MenuItem))]
    [System.Windows.TemplatePart(Name="PART_PasteMenuItem", Type=typeof(System.Windows.Controls.MenuItem))]
    [System.Windows.TemplatePart(Name="PART_SecondAmPmSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_SecondNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_SecondToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    [System.Windows.TemplatePart(Name="PART_SelectDateMenuItem", Type=typeof(System.Windows.Controls.MenuItem))]
    [System.Windows.TemplatePart(Name="PART_SelectTimeMenuItem", Type=typeof(System.Windows.Controls.MenuItem))]
    [System.Windows.TemplatePart(Name="PART_TimePicker", Type=typeof(Orc.Controls.TimePicker))]
    [System.Windows.TemplatePart(Name="PART_TimePickerPopup", Type=typeof(System.Windows.Controls.Primitives.Popup))]
    [System.Windows.TemplatePart(Name="PART_TodayMenuItem", Type=typeof(System.Windows.Controls.MenuItem))]
    [System.Windows.TemplatePart(Name="PART_YearNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_YearSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_YearToggleButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    public class DateTimePicker : System.Windows.Controls.Control, Orc.Controls.IEditableControl
    {
        public static readonly System.Windows.DependencyProperty AllowCopyPasteProperty;
        public static readonly System.Windows.DependencyProperty AllowNullProperty;
        public static readonly System.Windows.DependencyProperty AmPmValueProperty;
        public static readonly System.Windows.DependencyProperty CultureProperty;
        public static readonly System.Windows.DependencyProperty FirstDayOfWeekProperty;
        public static readonly System.Windows.DependencyProperty FormatProperty;
        public static readonly System.Windows.DependencyProperty HideSecondsProperty;
        public static readonly System.Windows.DependencyProperty HideTimeProperty;
        public static readonly System.Windows.DependencyProperty IsAmPmShortFormatProperty;
        public static readonly System.Windows.DependencyProperty IsHour12FormatProperty;
        public static readonly System.Windows.DependencyProperty IsReadOnlyProperty;
        public static readonly System.Windows.DependencyProperty IsYearShortFormatProperty;
        public static readonly System.Windows.DependencyProperty ShowOptionsButtonProperty;
        public static readonly System.Windows.DependencyProperty TimeValueProperty;
        public static readonly System.Windows.DependencyProperty ValueProperty;
        public DateTimePicker() { }
        public bool AllowCopyPaste { get; set; }
        public bool AllowNull { get; set; }
        public Orc.Controls.Enums.Meridiem AmPmValue { get; set; }
        public System.Globalization.CultureInfo Culture { get; set; }
        public System.DayOfWeek? FirstDayOfWeek { get; set; }
        public string Format { get; set; }
        public bool HideSeconds { get; set; }
        public bool HideTime { get; set; }
        public bool IsAmPmShortFormat { get; }
        public bool IsHour12Format { get; }
        public bool IsInEditMode { get; }
        public bool IsReadOnly { get; set; }
        public bool IsYearShortFormat { get; }
        public bool ShowOptionsButton { get; set; }
        public System.TimeSpan? TimeValue { get; set; }
        public System.DateTime? Value { get; set; }
        public event System.EventHandler<System.EventArgs> EditEnded;
        public event System.EventHandler<System.EventArgs> EditStarted;
        public event System.EventHandler<System.EventArgs> ValueChanged;
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
        protected override void OnIsKeyboardFocusWithinChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
        protected override void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
        protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
    }
    public static class DependencyObjectExtensions
    {
        public static System.Collections.Generic.IEnumerable<System.Windows.DependencyObject> GetDescendents(this System.Windows.DependencyObject root) { }
        public static System.Windows.DependencyObject GetVisualRoot(this System.Windows.DependencyObject dependencyObject) { }
    }
    public abstract class DialogWindowHostedToolBase<T> : Orc.Controls.ControlToolBase
        where T : Catel.MVVM.ViewModelBase
    {
        protected object Parameter;
        protected readonly Catel.IoC.ITypeFactory TypeFactory;
        protected readonly Catel.Services.IUIVisualizerService UIVisualizerService;
        protected T WindowViewModel;
        protected DialogWindowHostedToolBase(Catel.IoC.ITypeFactory typeFactory, Catel.Services.IUIVisualizerService uiVisualizerService) { }
        public virtual bool IsModal { get; }
        protected virtual void ApplyParameter(object parameter) { }
        public override void Close() { }
        protected abstract T InitializeViewModel();
        protected abstract void OnAccepted();
        protected override void OnOpen(object? parameter = null) { }
    }
    public class DirectoryPicker : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty LabelTextProperty;
        public static readonly System.Windows.DependencyProperty LabelWidthProperty;
        public static readonly System.Windows.DependencyProperty SelectedDirectoryProperty;
        public DirectoryPicker() { }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string LabelText { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public double LabelWidth { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string SelectedDirectory { get; set; }
        public void InitializeComponent() { }
    }
    public class DirectoryPickerViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData LabelTextProperty;
        public static readonly Catel.Data.IPropertyData LabelWidthProperty;
        public static readonly Catel.Data.IPropertyData SelectedDirectoryProperty;
        public DirectoryPickerViewModel(Catel.Services.ISelectDirectoryService selectDirectoryService, Orc.FileSystem.IDirectoryService directoryService, Catel.Services.IProcessService processService) { }
        public Catel.MVVM.Command Clear { get; }
        public string? LabelText { get; set; }
        public double LabelWidth { get; set; }
        public Catel.MVVM.Command OpenDirectory { get; }
        public Catel.MVVM.TaskCommand SelectDirectory { get; }
        public string? SelectedDirectory { get; set; }
    }
    public class DoNotShowDropDownOnClickComboboxBehavior : Catel.Windows.Interactivity.BehaviorBase<System.Windows.Controls.ComboBox>
    {
        public DoNotShowDropDownOnClickComboboxBehavior() { }
        protected override void OnAssociatedObjectLoaded() { }
        protected override void OnAssociatedObjectUnloaded() { }
    }
    [System.Windows.TemplatePart(Name="PART_Arrow", Type=typeof(System.Windows.Shapes.Path))]
    [System.Windows.TemplatePart(Name="PART_ArrowBorder", Type=typeof(System.Windows.Controls.Border))]
    public class DropDownButton : System.Windows.Controls.Primitives.ToggleButton
    {
        public static readonly System.Windows.DependencyProperty ArrowLocationProperty;
        public static readonly System.Windows.DependencyProperty ArrowMarginProperty;
        public static readonly System.Windows.DependencyProperty DropDownProperty;
        public static readonly System.Windows.DependencyProperty HeaderProperty;
        public static readonly System.Windows.DependencyProperty IsArrowVisibleProperty;
        public DropDownButton() { }
        public Orc.Controls.DropdownArrowLocation ArrowLocation { get; set; }
        public System.Windows.Thickness ArrowMargin { get; set; }
        public System.Windows.Controls.ContextMenu DropDown { get; set; }
        public object Header { get; set; }
        public bool IsArrowVisible { get; set; }
        public override void OnApplyTemplate() { }
        protected override void OnChecked(System.Windows.RoutedEventArgs e) { }
        protected override void OnContentChanged(object oldContent, object newContent) { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
        protected override void OnPreviewMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
        protected override void OnUnchecked(System.Windows.RoutedEventArgs e) { }
    }
    public enum DropdownArrowLocation
    {
        Left = 0,
        Top = 1,
        Right = 2,
        Bottom = 3,
    }
    public class DropdownArrowLocationConverter : Catel.MVVM.Converters.ValueConverterBase
    {
        public DropdownArrowLocationConverter() { }
        protected override object Convert(object value, System.Type targetType, object parameter) { }
    }
    public abstract class EditableControlBehaviorBase<T> : Catel.Windows.Interactivity.BehaviorBase<T>, Orc.Controls.IEditableControl
        where T : System.Windows.FrameworkElement
    {
        public static readonly System.Windows.DependencyProperty IsInEditModeProperty;
        protected EditableControlBehaviorBase() { }
        public bool IsInEditMode { get; set; }
        public event System.EventHandler<System.EventArgs> EditEnded;
        public event System.EventHandler<System.EventArgs> EditStarted;
        protected void RaiseEditEnded() { }
        protected void RaiseEditStarted() { }
    }
    public class EmptyCell : System.Windows.Controls.Control
    {
        public EmptyCell() { }
    }
    public class EmptyColumn : System.Windows.Controls.Control
    {
        public EmptyColumn() { }
    }
    public class EmptyRow : System.Windows.Controls.Control
    {
        public EmptyRow() { }
    }
    public static class EnterKeyTraversal
    {
        public static readonly System.Windows.DependencyProperty IsEnabledProperty;
        public static bool GetIsEnabled(System.Windows.DependencyObject obj) { }
        public static void SetIsEnabled(System.Windows.DependencyObject obj, bool value) { }
    }
    public enum ExpandDirection
    {
        Down = 0,
        Up = 1,
        Left = 2,
        Right = 3,
    }
    [System.Windows.TemplatePart(Name="PART_ExpandSite", Type=typeof(System.Windows.Controls.ContentPresenter))]
    [System.Windows.TemplatePart(Name="PART_HeaderSiteBorder", Type=typeof(System.Windows.Controls.Border))]
    [System.Windows.TemplateVisualState(GroupName="Expander", Name="Collapsed")]
    [System.Windows.TemplateVisualState(GroupName="Expander", Name="Expanded")]
    public class Expander : System.Windows.Controls.HeaderedContentControl
    {
        public static readonly System.Windows.DependencyProperty AutoResizeGridProperty;
        public static readonly System.Windows.DependencyProperty ExpandDirectionProperty;
        public static readonly System.Windows.DependencyProperty ExpandDurationProperty;
        public static readonly System.Windows.DependencyProperty IsExpandedProperty;
        public Expander() { }
        public bool AutoResizeGrid { get; set; }
        public Orc.Controls.ExpandDirection ExpandDirection { get; set; }
        public double ExpandDuration { get; set; }
        public bool IsExpanded { get; set; }
        public override void OnApplyTemplate() { }
        protected virtual void OnCollapsed() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected virtual void OnExpanded() { }
    }
    [System.Windows.TemplatePart(Name="PART_ClearButton", Type=typeof(System.Windows.Controls.Button))]
    [System.Windows.TemplatePart(Name="PART_WatermarkHost", Type=typeof(System.Windows.Controls.ContentPresenter))]
    public class FilterBox : System.Windows.Controls.TextBox
    {
        public static readonly System.Windows.DependencyProperty AllowAutoCompletionProperty;
        public static readonly System.Windows.DependencyProperty FilterSourceProperty;
        public static readonly System.Windows.DependencyProperty PropertyNameProperty;
        public static readonly System.Windows.DependencyProperty WatermarkProperty;
        public FilterBox() { }
        public bool AllowAutoCompletion { get; set; }
        public System.Collections.IEnumerable FilterSource { get; set; }
        public string PropertyName { get; set; }
        public string Watermark { get; set; }
        public event System.EventHandler<Orc.Controls.InitializingAutoCompletionServiceEventArgs> InitializingAutoCompletionService;
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected virtual void OnInitializingAutoCompletionService(Orc.Controls.InitializingAutoCompletionServiceEventArgs e) { }
        protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
        protected override void OnTextChanged(System.Windows.Controls.TextChangedEventArgs e) { }
    }
    public class FindReplaceSettings : Catel.Data.ModelBase
    {
        public static readonly Catel.Data.IPropertyData CaseSensitiveProperty;
        public static readonly Catel.Data.IPropertyData IsSearchUpProperty;
        public static readonly Catel.Data.IPropertyData UseRegexProperty;
        public static readonly Catel.Data.IPropertyData UseWildcardsProperty;
        public static readonly Catel.Data.IPropertyData WholeWordProperty;
        public FindReplaceSettings() { }
        public bool CaseSensitive { get; set; }
        public bool IsSearchUp { get; set; }
        public bool UseRegex { get; set; }
        public bool UseWildcards { get; set; }
        public bool WholeWord { get; set; }
    }
    public static class FindReplaceSettingsExtensions
    {
        public static System.Text.RegularExpressions.Regex GetRegEx(this Orc.Controls.FindReplaceSettings settings, string textToFind, bool isLeftToRight = false) { }
    }
    public class FindReplaceTool<TFindReplaceService> : Orc.Controls.ControlToolBase
        where TFindReplaceService : Orc.Controls.Services.IFindReplaceService
    {
        public FindReplaceTool(Catel.Services.IUIVisualizerService uiVisualizerService, Catel.IoC.ITypeFactory typeFactory) { }
        public override string Name { get; }
        public override void Attach(object target) { }
        public override void Close() { }
        protected virtual TFindReplaceService CreateFindReplaceService(object target) { }
        public override void Detach() { }
        protected override void OnOpen(object? parameter = null) { }
    }
    [System.Windows.TemplatePart(Name="PART_Canvas", Type=typeof(System.Windows.Controls.Canvas))]
    [System.Windows.TemplatePart(Name="PART_Dot1", Type=typeof(System.Windows.Shapes.Rectangle))]
    [System.Windows.TemplatePart(Name="PART_Dot2", Type=typeof(System.Windows.Shapes.Rectangle))]
    [System.Windows.TemplatePart(Name="PART_Dot3", Type=typeof(System.Windows.Shapes.Rectangle))]
    [System.Windows.TemplatePart(Name="PART_Dot4", Type=typeof(System.Windows.Shapes.Rectangle))]
    [System.Windows.TemplatePart(Name="PART_Dot5", Type=typeof(System.Windows.Shapes.Rectangle))]
    public class FluidProgressBar : System.Windows.Controls.Control, System.IDisposable
    {
        public static readonly System.Windows.DependencyProperty DelayProperty;
        public static readonly System.Windows.DependencyProperty DotHeightProperty;
        public static readonly System.Windows.DependencyProperty DotRadiusXProperty;
        public static readonly System.Windows.DependencyProperty DotRadiusYProperty;
        public static readonly System.Windows.DependencyProperty DotWidthProperty;
        public static readonly System.Windows.DependencyProperty DurationAProperty;
        public static readonly System.Windows.DependencyProperty DurationBProperty;
        public static readonly System.Windows.DependencyProperty DurationCProperty;
        public static readonly System.Windows.DependencyProperty KeyFrameAProperty;
        public static readonly System.Windows.DependencyProperty KeyFrameBProperty;
        public static readonly System.Windows.DependencyProperty OscillateProperty;
        public static readonly System.Windows.DependencyProperty ReverseDurationProperty;
        public static readonly System.Windows.DependencyProperty TotalDurationProperty;
        public FluidProgressBar() { }
        public System.Windows.Duration Delay { get; set; }
        public double DotHeight { get; set; }
        public double DotRadiusX { get; set; }
        public double DotRadiusY { get; set; }
        public double DotWidth { get; set; }
        public System.Windows.Duration DurationA { get; set; }
        public System.Windows.Duration DurationB { get; set; }
        public System.Windows.Duration DurationC { get; set; }
        public double KeyFrameA { get; set; }
        public double KeyFrameB { get; set; }
        public bool Oscillate { get; set; }
        public System.Windows.Duration ReverseDuration { get; set; }
        public System.Windows.Duration TotalDuration { get; set; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected override void Finalize() { }
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected virtual void OnDelayChanged(System.Windows.Duration oldDelay, System.Windows.Duration newDelay) { }
        protected virtual void OnDotHeightChanged(double oldDotHeight, double newDotHeight) { }
        protected virtual void OnDotRadiusXChanged(double oldDotRadiusX, double newDotRadiusX) { }
        protected virtual void OnDotRadiusYChanged(double oldDotRadiusY, double newDotRadiusY) { }
        protected virtual void OnDotWidthChanged(double oldDotWidth, double newDotWidth) { }
        protected virtual void OnDurationAChanged(System.Windows.Duration oldDurationA, System.Windows.Duration newDurationA) { }
        protected virtual void OnDurationBChanged(System.Windows.Duration oldDurationB, System.Windows.Duration newDurationB) { }
        protected virtual void OnDurationCChanged(System.Windows.Duration oldDurationC, System.Windows.Duration newDurationC) { }
        protected virtual void OnKeyFrameAChanged(double oldKeyFrameA, double newKeyFrameA) { }
        protected virtual void OnKeyFrameBChanged(double oldKeyFrameB, double newKeyFrameB) { }
        protected virtual void OnOscillateChanged(bool oldOscillate, bool newOscillate) { }
        protected virtual void OnReverseDurationChanged(System.Windows.Duration oldReverseDuration, System.Windows.Duration newReverseDuration) { }
        protected virtual void OnTotalDurationChanged(System.Windows.Duration oldTotalDuration, System.Windows.Duration newTotalDuration) { }
    }
    [System.Windows.TemplatePart(Name="PART_Image", Type=typeof(System.Windows.Controls.Image))]
    public class FontImage : System.Windows.Controls.Control
    {
        public static readonly System.Windows.DependencyProperty ItemNameProperty;
        public FontImage() { }
        public string ItemName { get; set; }
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class FrameCounter : System.Windows.Controls.TextBlock
    {
        public static readonly System.Windows.DependencyProperty PrefixProperty;
        public static readonly System.Windows.DependencyProperty ResetCountProperty;
        public FrameCounter() { }
        public string Prefix { get; set; }
        public int ResetCount { get; set; }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class FrameRateCounter : System.Windows.Controls.TextBlock
    {
        public static readonly System.Windows.DependencyProperty PrefixProperty;
        public FrameRateCounter() { }
        public string Prefix { get; set; }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public static class FrameworkElementExtensions
    {
        public static void AttachAndOpenTool(this System.Windows.FrameworkElement frameworkElement, System.Type toolType, object parameter = null) { }
        public static void AttachAndOpenTool<T>(this System.Windows.FrameworkElement frameworkElement, object parameter = null)
            where T :  class, Orc.Controls.IControlTool { }
        public static object AttachTool(this System.Windows.FrameworkElement frameworkElement, System.Type toolType) { }
        public static T AttachTool<T>(this System.Windows.FrameworkElement frameworkElement)
            where T :  class, Orc.Controls.IControlTool { }
        public static bool CanAttach(this System.Windows.FrameworkElement frameworkElement, System.Type toolType) { }
        public static bool DetachTool(this System.Windows.FrameworkElement frameworkElement, System.Type toolType) { }
        public static System.Windows.Point GetCenterPointInRoot(this System.Windows.FrameworkElement frameworkElement, System.Windows.FrameworkElement root) { }
        public static Orc.Controls.Tools.IControlToolManager GetControlToolManager(this System.Windows.FrameworkElement frameworkElement) { }
        public static System.Windows.Rect GetScreenRect(this System.Windows.FrameworkElement frameworkElement) { }
        public static System.Collections.Generic.IList<Orc.Controls.IControlTool> GetTools(this System.Windows.FrameworkElement frameworkElement) { }
        public static Orc.Controls.IEditableControl TryGetEditableControl(this System.Windows.FrameworkElement frameworkElement) { }
    }
    public class HeaderBar : System.Windows.Controls.Control
    {
        public static readonly System.Windows.DependencyProperty HeaderProperty;
        public HeaderBar() { }
        public string Header { get; set; }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public interface IApplicationLogFilterGroupService
    {
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Orc.Controls.LogFilterGroup>> LoadAsync();
        System.Threading.Tasks.Task SaveAsync(System.Collections.Generic.IEnumerable<Orc.Controls.LogFilterGroup> filterGroups);
    }
    public interface ICallout
    {
        System.Windows.Input.ICommand Command { get; }
        bool HasShown { get; }
        System.Guid Id { get; }
        bool IsClosable { get; }
        bool IsOpen { get; }
        string Name { get; }
        System.TimeSpan ShowTime { get; set; }
        object Tag { get; }
        string Title { get; }
        string Version { get; }
        event System.EventHandler<Orc.Controls.CalloutEventArgs> Hiding;
        event System.EventHandler<Orc.Controls.CalloutEventArgs> Showing;
        void Hide();
        void Show();
    }
    public static class ICalloutExtensions
    {
        public static string GetCalloutConfigurationKeyPrefix(this Orc.Controls.ICallout callout) { }
        public static string GetCalloutConfigurationKeyPrefix(string name, string version) { }
    }
    public interface ICalloutManager
    {
        System.Collections.Generic.List<Orc.Controls.ICallout> Callouts { get; }
        bool IsSuspended { get; }
        event System.EventHandler<Orc.Controls.CalloutEventArgs> Hiding;
        event System.EventHandler<Orc.Controls.CalloutEventArgs> Registered;
        event System.EventHandler<Orc.Controls.CalloutEventArgs> Showing;
        event System.EventHandler<Orc.Controls.CalloutEventArgs> Unregistered;
        void Clear();
        void Register(Orc.Controls.ICallout callout);
        void Resume();
        void Suspend();
        void Unregister(Orc.Controls.ICallout callout);
    }
    public static class ICalloutManagerExtensions
    {
        public static Orc.Controls.ICallout FindCallout(this Orc.Controls.ICalloutManager calloutManager, System.Guid id) { }
        public static Orc.Controls.ICallout FindCallout(this Orc.Controls.ICalloutManager calloutManager, string name) { }
        public static void HideAllCallouts(this Orc.Controls.ICalloutManager calloutManager) { }
        public static void HideCallout(this Orc.Controls.ICalloutManager calloutManager, System.Guid id) { }
        public static void HideCallout(this Orc.Controls.ICalloutManager calloutManager, string name) { }
        public static bool IsAnyCalloutOpen(this Orc.Controls.ICalloutManager calloutManager) { }
        public static void ShowAllCallouts(this Orc.Controls.ICalloutManager calloutManager) { }
        public static void ShowCallout(this Orc.Controls.ICalloutManager calloutManager, System.Guid id, System.Func<Orc.Controls.ICallout, bool> predicate = null) { }
        public static void ShowCallout(this Orc.Controls.ICalloutManager calloutManager, string name, System.Func<Orc.Controls.ICallout, bool> predicate = null) { }
        public static System.IDisposable SuspendInScope(this Orc.Controls.ICalloutManager calloutManager) { }
    }
    public interface IColorLegendItem : System.ComponentModel.INotifyPropertyChanged
    {
        string AdditionalData { get; set; }
        System.Windows.Media.Color Color { get; set; }
        string Description { get; set; }
        string Id { get; set; }
        bool IsChecked { get; set; }
        bool IsSelected { get; set; }
    }
    public static class IConfigurationServiceExtensions
    {
        public static System.Threading.Tasks.Task<System.DateTime?> GetCalloutLastShownAsync(this Catel.Configuration.IConfigurationService configurationService, Orc.Controls.ICallout callout) { }
        public static System.Threading.Tasks.Task<bool> IsCalloutMarkedAsShownAsync(this Catel.Configuration.IConfigurationService configurationService, Orc.Controls.ICallout callout) { }
        public static System.Threading.Tasks.Task MarkCalloutAsNotShownAsync(this Catel.Configuration.IConfigurationService configurationService, Orc.Controls.ICallout callout) { }
        public static System.Threading.Tasks.Task MarkCalloutAsShownAsync(this Catel.Configuration.IConfigurationService configurationService, Orc.Controls.ICallout callout) { }
        public static System.Threading.Tasks.Task SetCalloutLastShownAsync(this Catel.Configuration.IConfigurationService configurationService, Orc.Controls.ICallout callout) { }
        public static System.Threading.Tasks.Task SetCalloutLastShownAsync(this Catel.Configuration.IConfigurationService configurationService, Orc.Controls.ICallout callout, System.DateTime? lastShown) { }
    }
    public interface IControlTool
    {
        bool IsEnabled { get; }
        bool IsOpened { get; }
        string Name { get; }
        event System.EventHandler<System.EventArgs> Attached;
        event System.EventHandler<System.EventArgs> Closed;
        event System.EventHandler<System.EventArgs> Detached;
        event System.EventHandler<System.EventArgs> Opened;
        event System.EventHandler<System.EventArgs> Opening;
        void Attach(object target);
        void Close();
        void Detach();
        void Open(object parameter);
    }
    public interface IEditableControl
    {
        bool IsInEditMode { get; }
        event System.EventHandler<System.EventArgs> EditEnded;
        event System.EventHandler<System.EventArgs> EditStarted;
    }
    public interface IStepBarItem
    {
        System.Windows.Input.ICommand? Command { get; }
        string? Description { get; }
        int Number { get; }
        Orc.Controls.StepBarItemStates State { get; set; }
        string? Title { get; }
    }
    public static class IStepBarItemExtensions
    {
        public static bool IsSkipped(this Orc.Controls.StepBarItemStates state) { }
    }
    public interface ISuggestionListService
    {
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> GetSuggestionList(System.DateTime dateTime, Orc.Controls.DateTimePart editablePart, Orc.Controls.DateTimeFormatInfo dateTimeFormatInfo);
    }
    public interface ITimeAdjustmentProvider
    {
        Orc.Controls.TimeAdjustment GetTimeAdjustment(Orc.Controls.TimeAdjustmentStrategy strategy);
    }
    public interface IValidationContextTreeNode
    {
        System.Collections.Generic.IEnumerable<Orc.Controls.IValidationContextTreeNode> Children { get; }
        string DisplayName { get; }
        bool IsExpanded { get; set; }
        bool IsVisible { get; set; }
        Catel.Data.ValidationResultType? ResultType { get; }
    }
    public static class IValidationContextTreeNodeExtensions
    {
        public static void CollapseAll(this System.Collections.Generic.IEnumerable<Orc.Controls.IValidationContextTreeNode> nodes) { }
        public static void ExpandAll(this System.Collections.Generic.IEnumerable<Orc.Controls.IValidationContextTreeNode> nodes) { }
        public static bool HasAnyCollapsed(this System.Collections.Generic.IEnumerable<Orc.Controls.IValidationContextTreeNode> nodes) { }
        public static bool HasAnyExpanded(this System.Collections.Generic.IEnumerable<Orc.Controls.IValidationContextTreeNode> nodes) { }
        public static string ToText(this System.Collections.Generic.IEnumerable<Orc.Controls.IValidationContextTreeNode> validationContextTreeNodes) { }
    }
    public interface IValidationNamesService
    {
        void Clear();
        System.Collections.Generic.IEnumerable<Catel.Data.IValidationResult> GetCachedResultsByTagName(string tagName);
        string GetDisplayName(Catel.Data.IValidationResult validationResult);
        int? GetLineNumber(Catel.Data.IValidationResult validationResult);
        string GetTagName(Catel.Data.IValidationResult validationResult);
    }
    public class InfinityScrollListBoxBehavior : Catel.Windows.Interactivity.BehaviorBase<System.Windows.Controls.ListBox>
    {
        public static readonly System.Windows.DependencyProperty CommandParameterProperty;
        public static readonly System.Windows.DependencyProperty CommandProperty;
        public static readonly System.Windows.DependencyProperty IsCommandExecutingProperty;
        public static readonly System.Windows.DependencyProperty ScrollSizeProperty;
        public InfinityScrollListBoxBehavior() { }
        public Catel.MVVM.TaskCommand Command { get; set; }
        public object CommandParameter { get; set; }
        public bool IsCommandExecuting { get; set; }
        public int ScrollSize { get; set; }
        protected override void OnAssociatedObjectLoaded() { }
        protected override void OnAssociatedObjectUnloaded() { }
    }
    public class InitializingAutoCompletionServiceEventArgs : System.Windows.RoutedEventArgs
    {
        public InitializingAutoCompletionServiceEventArgs() { }
        public Catel.Services.IAutoCompletionService AutoCompletionService { get; set; }
    }
    public static class InlineExtensions
    {
        public static System.Windows.Documents.Inline Append(this System.Windows.Documents.Inline inline, System.Windows.Documents.Inline inlineToAdd) { }
        public static System.Windows.Documents.Inline AppendRange(this System.Windows.Documents.Inline inline, System.Collections.Generic.IEnumerable<System.Windows.Documents.Inline> inlines) { }
        public static System.Windows.Documents.Bold Bold(this System.Windows.Documents.Inline inline) { }
    }
    public class IsAfterCurrentStepToVisibilityConverter : Catel.MVVM.Converters.VisibilityConverterBase
    {
        public IsAfterCurrentStepToVisibilityConverter() { }
        protected override bool IsVisible(object? value, System.Type targetType, object? parameter) { }
    }
    public class IsBeforeCurrentStepToVisibilityConverter : Catel.MVVM.Converters.VisibilityConverterBase
    {
        public IsBeforeCurrentStepToVisibilityConverter() { }
        protected override bool IsVisible(object? value, System.Type targetType, object? parameter) { }
    }
    public class IsCurrentStepToVisibilityConverter : Catel.MVVM.Converters.VisibilityConverterBase
    {
        public IsCurrentStepToVisibilityConverter() { }
        protected override bool IsVisible(object? value, System.Type targetType, object? parameter) { }
    }
    public class IsLastStepBarToVisibilityConverter : Catel.MVVM.Converters.VisibilityConverterBase
    {
        public IsLastStepBarToVisibilityConverter() { }
        protected override bool IsVisible(object? value, System.Type targetType, object? parameter) { }
    }
    public class IsSkippedStepToVisibilityConverter : Catel.MVVM.Converters.VisibilityConverterBase
    {
        public IsSkippedStepToVisibilityConverter() { }
        protected override bool IsVisible(object? value, System.Type targetType, object? parameter) { }
    }
    public class IsVisitedStepToVisibilityConverter : Catel.MVVM.Converters.VisibilityConverterBase
    {
        public IsVisitedStepToVisibilityConverter() { }
        protected override bool IsVisible(object? value, System.Type targetType, object? parameter) { }
    }
    [System.Windows.StyleTypedProperty(Property="HyperlinkStyle", StyleTargetType=typeof(System.Windows.Documents.Hyperlink))]
    [System.Windows.TemplatePart(Name="PART_InnerHyperlink", Type=typeof(System.Windows.Documents.Hyperlink))]
    public class LinkLabel : System.Windows.Controls.Label
    {
        public static readonly System.Windows.DependencyProperty ClickBehaviorProperty;
        [System.ComponentModel.Category("Behavior")]
        public static readonly System.Windows.RoutedEvent ClickEvent;
        public static readonly System.Windows.DependencyProperty CommandParameterProperty;
        public static readonly System.Windows.DependencyProperty CommandProperty;
        public static readonly System.Windows.DependencyProperty CommandTargetProperty;
        public static readonly System.Windows.DependencyProperty HasUrlProperty;
        public static readonly System.Windows.DependencyProperty HoverForegroundProperty;
        public static readonly System.Windows.DependencyProperty HyperlinkStyleProperty;
        public static readonly System.Windows.DependencyProperty LinkLabelBehaviorProperty;
        [System.ComponentModel.Category("Behavior")]
        public static readonly System.Windows.RoutedEvent RequestNavigateEvent;
        public static readonly System.Windows.DependencyProperty UrlProperty;
        public LinkLabel() { }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Common Properties")]
        public Orc.Controls.LinkLabelClickBehavior ClickBehavior { get; set; }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Action")]
        [System.Windows.Localizability(System.Windows.LocalizationCategory.NeverLocalize)]
        public System.Windows.Input.ICommand Command { get; set; }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Action")]
        [System.Windows.Localizability(System.Windows.LocalizationCategory.NeverLocalize)]
        public object CommandParameter { get; set; }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Action")]
        public System.Windows.IInputElement CommandTarget { get; set; }
        public bool HasUrl { get; }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Brushes")]
        public System.Windows.Media.Brush HoverForeground { get; set; }
        public System.Windows.Style HyperlinkStyle { get; set; }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Common Properties")]
        public Orc.Controls.LinkLabelBehavior LinkLabelBehavior { get; set; }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Common Properties")]
        public System.Uri Url { get; set; }
        public event System.Windows.RoutedEventHandler Click;
        public event System.Windows.Navigation.RequestNavigateEventHandler RequestNavigate;
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public enum LinkLabelBehavior
    {
        SystemDefault = 0,
        AlwaysUnderline = 1,
        HoverUnderline = 2,
        NeverUnderline = 3,
    }
    public enum LinkLabelClickBehavior
    {
        Undefined = 0,
        OpenUrlInBrowser = 1,
    }
    public static class ListBoxExtensions
    {
        public static readonly System.Windows.DependencyProperty HorizontalOffsetProperty;
        public static readonly System.Windows.DependencyProperty VerticalOffsetProperty;
        public static void CenterSelectedItem(this System.Windows.Controls.ListBox listBox, System.Windows.Controls.Orientation orientation) { }
        public static double GetHorizontalOffset(System.Windows.FrameworkElement target) { }
        public static double GetVerticalOffset(System.Windows.FrameworkElement target) { }
        public static void SetHorizontalOffset(System.Windows.FrameworkElement target, double value) { }
        public static void SetVerticalOffset(System.Windows.FrameworkElement target, double value) { }
    }
    public class ListTextBox : System.Windows.Controls.TextBox
    {
        public static readonly System.Windows.DependencyProperty ListOfValuesProperty;
        public static readonly System.Windows.DependencyProperty ValueProperty;
        public ListTextBox() { }
        public System.Collections.Generic.IList<string> ListOfValues { get; set; }
        public string Value { get; set; }
        public event System.EventHandler LeftBoundReached;
        public event System.EventHandler RightBoundReached;
        public event System.EventHandler ValueChanged;
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
        protected override void OnPreviewTextInput(System.Windows.Input.TextCompositionEventArgs e) { }
    }
    public enum LoadTabItemsBehavior
    {
        LazyLoading = 0,
        LazyLoadingUnloadOthers = 1,
        EagerLoading = 2,
        EagerLoadingOnFirstUse = 3,
    }
    public class LogEntryDoubleClickEventArgs : System.EventArgs
    {
        public LogEntryDoubleClickEventArgs(Catel.Logging.LogEntry logEntry) { }
        public Catel.Logging.LogEntry LogEntry { get; }
    }
    public class LogEntryEventArgs : System.EventArgs
    {
        public LogEntryEventArgs(System.Collections.Generic.List<Catel.Logging.LogEntry> logEntries, System.Collections.Generic.List<Catel.Logging.LogEntry> filteredLogEntries) { }
        public System.Collections.Generic.List<Catel.Logging.LogEntry> FilteredLogEntries { get; }
        public System.Collections.Generic.List<Catel.Logging.LogEntry> LogEntries { get; }
    }
    public class LogFilter : Catel.Data.ModelBase
    {
        public static readonly Catel.Data.IPropertyData? ActionProperty;
        public static readonly Catel.Data.IPropertyData? ExpressionTypeProperty;
        public static readonly Catel.Data.IPropertyData? ExpressionValueProperty;
        public static readonly Catel.Data.IPropertyData? NameProperty;
        public static readonly Catel.Data.IPropertyData? TargetProperty;
        public LogFilter() { }
        public Orc.Controls.LogFilterAction Action { get; set; }
        public Orc.Controls.LogFilterExpressionType ExpressionType { get; set; }
        public string? ExpressionValue { get; set; }
        public string? Name { get; set; }
        public Orc.Controls.LogFilterTarget Target { get; set; }
        public bool Pass(Catel.Logging.LogEntry logEntry) { }
    }
    public enum LogFilterAction
    {
        Include = 0,
        Exclude = 1,
    }
    public class LogFilterEditorControl : Catel.Windows.DataWindow, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty LogFilterProperty;
        public LogFilterEditorControl() { }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.ViewModelToView)]
        public Orc.Controls.LogFilter LogFilter { get; set; }
        public void InitializeComponent() { }
    }
    public class LogFilterEditorViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData ActionProperty;
        public static readonly Catel.Data.IPropertyData ActionsProperty;
        public static readonly Catel.Data.IPropertyData ExpressionTypeProperty;
        public static readonly Catel.Data.IPropertyData ExpressionTypesProperty;
        public static readonly Catel.Data.IPropertyData ExpressionValueProperty;
        public static readonly Catel.Data.IPropertyData LogFilterProperty;
        public static readonly Catel.Data.IPropertyData NameProperty;
        public static readonly Catel.Data.IPropertyData TargetProperty;
        public static readonly Catel.Data.IPropertyData TargetsProperty;
        public LogFilterEditorViewModel(Orc.Controls.LogFilter logFilter) { }
        [Catel.MVVM.ViewModelToModel("", "")]
        public Orc.Controls.LogFilterAction Action { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<Orc.Controls.LogFilterAction> Actions { get; }
        [Catel.MVVM.ViewModelToModel("", "")]
        public Orc.Controls.LogFilterExpressionType ExpressionType { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<Orc.Controls.LogFilterExpressionType> ExpressionTypes { get; }
        [Catel.MVVM.ViewModelToModel("", "")]
        public string? ExpressionValue { get; set; }
        [Catel.MVVM.Model]
        public Orc.Controls.LogFilter? LogFilter { get; set; }
        [Catel.MVVM.ViewModelToModel("", "")]
        public string? Name { get; set; }
        [Catel.MVVM.ViewModelToModel("", "")]
        public Orc.Controls.LogFilterTarget Target { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<Orc.Controls.LogFilterTarget> Targets { get; }
        protected override void ValidateFields(System.Collections.Generic.List<Catel.Data.IFieldValidationResult> validationResults) { }
    }
    public enum LogFilterExpressionType
    {
        Contains = 0,
        NotStartsWith = 1,
        StartsWith = 2,
        NotContains = 3,
        Equals = 4,
        NotEquals = 5,
    }
    public class LogFilterGroup : Catel.Data.ModelBase
    {
        public static readonly Catel.Data.IPropertyData IsEnabledProperty;
        public static readonly Catel.Data.IPropertyData IsRuntimeProperty;
        public static readonly Catel.Data.IPropertyData LogFiltersProperty;
        public static readonly Catel.Data.IPropertyData NameProperty;
        public LogFilterGroup() { }
        public bool IsEnabled { get; set; }
        public bool IsRuntime { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<Orc.Controls.LogFilter> LogFilters { get; set; }
        public string Name { get; set; }
        public bool Pass(Catel.Logging.LogEntry logEntry) { }
        public override string ToString() { }
    }
    public class LogFilterGroupEditorViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData LogFilterGroupProperty;
        public static readonly Catel.Data.IPropertyData LogFiltersProperty;
        public static readonly Catel.Data.IPropertyData NameProperty;
        public static readonly Catel.Data.IPropertyData SelectedLogFilterProperty;
        public LogFilterGroupEditorViewModel(Orc.Controls.LogFilterGroup logFilterGroup, Catel.Services.IMessageService messageService, Catel.Services.IUIVisualizerService uiVisualizerService) { }
        public Catel.MVVM.TaskCommand AddCommand { get; }
        public Catel.MVVM.TaskCommand EditCommand { get; }
        [Catel.MVVM.Model]
        public Orc.Controls.LogFilterGroup LogFilterGroup { get; set; }
        [Catel.MVVM.ViewModelToModel("LogFilterGroup", "")]
        public System.Collections.ObjectModel.ObservableCollection<Orc.Controls.LogFilter> LogFilters { get; set; }
        [Catel.MVVM.ViewModelToModel("LogFilterGroup", "")]
        public string? Name { get; set; }
        public Catel.MVVM.TaskCommand RemoveCommand { get; }
        public Orc.Controls.LogFilter? SelectedLogFilter { get; set; }
        public override string Title { get; }
        protected override void OnValidating(Catel.Data.IValidationContext validationContext) { }
    }
    public class LogFilterGroupEditorWindow : Catel.Windows.DataWindow, System.Windows.Markup.IComponentConnector
    {
        public LogFilterGroupEditorWindow() { }
        public void InitializeComponent() { }
    }
    public class LogFilterGroupList : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public LogFilterGroupList() { }
        public event System.EventHandler<System.EventArgs> Updated;
        public void InitializeComponent() { }
        protected override void OnViewModelChanged() { }
    }
    public class LogFilterGroupListViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData FilterGroupsProperty;
        public static readonly Catel.Data.IPropertyData SelectedFilterGroupProperty;
        public static readonly Catel.Data.IPropertyData SelectedFilterGroupsProperty;
        public LogFilterGroupListViewModel(Orc.Controls.IApplicationLogFilterGroupService applicationLogFilterGroupService, Catel.Services.IMessageService messageService, Catel.Services.IUIVisualizerService uiVisualizerService) { }
        public Catel.MVVM.TaskCommand AddCommand { get; set; }
        public Catel.MVVM.TaskCommand EditCommand { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<Orc.Controls.LogFilterGroup> FilterGroups { get; }
        public Catel.MVVM.TaskCommand RemoveCommand { get; set; }
        public Orc.Controls.LogFilterGroup? SelectedFilterGroup { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<Orc.Controls.LogFilterGroup> SelectedFilterGroups { get; }
        public event System.EventHandler<System.EventArgs>? Updated;
        protected override System.Threading.Tasks.Task InitializeAsync() { }
    }
    public enum LogFilterTarget
    {
        TypeName = 0,
        AssemblyName = 1,
        LogMessage = 2,
    }
    [System.Windows.TemplatePart(Name="PART_Toggle", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    public class LogMessageCategoryToggleButton : System.Windows.Controls.Control
    {
        public static readonly System.Windows.DependencyProperty CategoryProperty;
        public static readonly System.Windows.DependencyProperty EntryCountProperty;
        public static readonly System.Windows.DependencyProperty IsCheckedProperty;
        public LogMessageCategoryToggleButton() { }
        public string Category { get; set; }
        public int EntryCount { get; set; }
        public bool IsChecked { get; set; }
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        public void Toggle() { }
    }
    public class LogRecord
    {
        public LogRecord() { }
        public System.DateTime DateTime { get; set; }
        public Catel.Logging.LogEvent LogEvent { get; set; }
        public string Message { get; set; }
    }
    public class LogViewerControl : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty ActiveFilterGroupProperty;
        public static readonly System.Windows.DependencyProperty AutoScrollProperty;
        public static readonly System.Windows.DependencyProperty DebugMessageBrushProperty;
        public static readonly System.Windows.DependencyProperty EnableIconsProperty;
        public static readonly System.Windows.DependencyProperty EnableTextColoringProperty;
        public static readonly System.Windows.DependencyProperty EnableThreadIdProperty;
        public static readonly System.Windows.DependencyProperty EnableTimestampProperty;
        public static readonly System.Windows.DependencyProperty ErrorMessageBrushProperty;
        public static readonly System.Windows.DependencyProperty IgnoreCatelLoggingProperty;
        public static readonly System.Windows.DependencyProperty InfoMessageBrushProperty;
        public static readonly System.Windows.DependencyProperty LogFilterProperty;
        public static readonly System.Windows.DependencyProperty LogListenerTypeProperty;
        public static readonly System.Windows.DependencyProperty MaximumUpdateBatchSizeProperty;
        public static readonly System.Windows.DependencyProperty ScrollModeProperty;
        public static readonly System.Windows.DependencyProperty ShowDebugProperty;
        public static readonly System.Windows.DependencyProperty ShowErrorProperty;
        public static readonly System.Windows.DependencyProperty ShowInfoProperty;
        public static readonly System.Windows.DependencyProperty ShowMultilineMessagesExpandedProperty;
        public static readonly System.Windows.DependencyProperty ShowWarningProperty;
        public static readonly System.Windows.DependencyProperty SupportCommandManagerProperty;
        public static readonly System.Windows.DependencyProperty WarningMessageBrushProperty;
        public LogViewerControl() { }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public Orc.Controls.LogFilterGroup ActiveFilterGroup { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool AutoScroll { get; set; }
        public System.Windows.Media.Brush DebugMessageBrush { get; set; }
        public bool EnableIcons { get; set; }
        public bool EnableTextColoring { get; set; }
        public bool EnableThreadId { get; set; }
        public bool EnableTimestamp { get; set; }
        public System.Windows.Media.Brush ErrorMessageBrush { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool IgnoreCatelLogging { get; set; }
        public System.Windows.Media.Brush InfoMessageBrush { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string LogFilter { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public System.Type LogListenerType { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public int MaximumUpdateBatchSize { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public Orc.Controls.ScrollMode ScrollMode { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool ShowDebug { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool ShowError { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool ShowInfo { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool ShowMultilineMessagesExpanded { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool ShowWarning { get; set; }
        public bool SupportCommandManager { get; set; }
        public System.Windows.Media.Brush WarningMessageBrush { get; set; }
        public event System.EventHandler<Orc.Controls.LogEntryDoubleClickEventArgs> LogEntryDoubleClick;
        public void Clear() { }
        public void CollapseAllMultilineLogMessages() { }
        public void CopyToClipboard() { }
        public void ExpandAllMultilineLogMessages() { }
        public void InitializeComponent() { }
        protected override void OnLoaded(System.EventArgs e) { }
        protected override void OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
        protected override void OnViewModelChanged() { }
        protected override void OnViewModelPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    }
    public class LogViewerLogListener : Catel.Logging.RollingInMemoryLogListener
    {
        public LogViewerLogListener() { }
    }
    public static class LoggingExtensions
    {
        public static System.Collections.Generic.IEnumerable<Orc.Controls.RichTextBoxParagraph> ConvertToParagraphs(this System.Collections.Generic.IEnumerable<Catel.Logging.LogEntry> logEntries) { }
    }
    public static class MediaElementThreadFactory
    {
        public static Orc.Controls.MediaElementThreadInfo CreateMediaElementsOnWorkerThread(System.Func<System.Windows.Media.Visual> createVisual) { }
    }
    public class MediaElementThreadInfo : Catel.Disposable
    {
        public MediaElementThreadInfo(System.Windows.Media.HostVisual hostVisual, System.Func<System.Windows.Media.Visual> createVisual, System.Threading.Thread thread) { }
        public System.Func<System.Windows.Media.Visual> CreateVisual { get; }
        public System.Windows.Threading.Dispatcher Dispatcher { get; }
        public System.Windows.Media.HostVisual HostVisual { get; }
        public int Id { get; }
        public System.Threading.Thread Thread { get; }
        protected override void DisposeManaged() { }
        public void UpdateDispatcher(System.Windows.Threading.Dispatcher dispatcher) { }
    }
    public class MultipleCommandParameterConverter : System.Windows.Data.IMultiValueConverter
    {
        public MultipleCommandParameterConverter() { }
        public object Convert(object[] values, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) { }
    }
    [System.ComponentModel.TypeConverter(typeof(Orc.Controls.Converters.NumberTypeConverter))]
    public readonly struct Number
    {
        public readonly double DValue;
        public readonly bool IsValid;
        public readonly double MaxValue;
        public readonly double MinValue;
        public readonly System.Type Type;
        public readonly object Value;
        public Number(object value) { }
        public Number(object value, System.Type type) { }
        public static byte op_Implicit(Orc.Controls.Number number) { }
        public static sbyte op_Implicit(Orc.Controls.Number number) { }
        public static short op_Implicit(Orc.Controls.Number number) { }
        public static ushort op_Implicit(Orc.Controls.Number number) { }
        public static int op_Implicit(Orc.Controls.Number number) { }
        public static uint op_Implicit(Orc.Controls.Number number) { }
        public static long op_Implicit(Orc.Controls.Number number) { }
        public static ulong op_Implicit(Orc.Controls.Number number) { }
        public static decimal op_Implicit(Orc.Controls.Number number) { }
        public static float op_Implicit(Orc.Controls.Number number) { }
        public static double op_Implicit(Orc.Controls.Number number) { }
        public static Orc.Controls.Number op_Implicit(byte value) { }
        public static Orc.Controls.Number op_Implicit(decimal value) { }
        public static Orc.Controls.Number op_Implicit(double value) { }
        public static Orc.Controls.Number op_Implicit(short value) { }
        public static Orc.Controls.Number op_Implicit(int value) { }
        public static Orc.Controls.Number op_Implicit(long value) { }
        public static Orc.Controls.Number op_Implicit(sbyte value) { }
        public static Orc.Controls.Number op_Implicit(float value) { }
        public static Orc.Controls.Number op_Implicit(ushort value) { }
        public static Orc.Controls.Number op_Implicit(uint value) { }
        public static Orc.Controls.Number op_Implicit(ulong value) { }
        public static Orc.Controls.Number operator +(Orc.Controls.Number left, double right) { }
        public static Orc.Controls.Number operator +(double left, Orc.Controls.Number right) { }
        public static Orc.Controls.Number operator -(Orc.Controls.Number left, double right) { }
        public static Orc.Controls.Number operator -(double left, Orc.Controls.Number right) { }
        public static bool operator <(Orc.Controls.Number left, Orc.Controls.Number right) { }
        public static bool operator <(Orc.Controls.Number left, double right) { }
        public static bool operator <(double left, Orc.Controls.Number right) { }
        public static bool operator <=(Orc.Controls.Number left, Orc.Controls.Number right) { }
        public static bool operator <=(Orc.Controls.Number left, double right) { }
        public static bool operator <=(double left, Orc.Controls.Number right) { }
        public static bool operator >(Orc.Controls.Number left, Orc.Controls.Number right) { }
        public static bool operator >(Orc.Controls.Number left, double right) { }
        public static bool operator >(double left, Orc.Controls.Number right) { }
        public static bool operator >=(Orc.Controls.Number left, Orc.Controls.Number right) { }
        public static bool operator >=(Orc.Controls.Number left, double right) { }
        public static bool operator >=(double left, Orc.Controls.Number right) { }
    }
    public static class NumberExtensions
    {
        public static object ConvertTo(this Orc.Controls.Number number, System.Type convertToType) { }
        public static T ConvertTo<T>(this Orc.Controls.Number number) { }
    }
    public static class NumberFormatHelper
    {
        public static string GetFormat(int digits) { }
    }
    public class NumericTextBox : System.Windows.Controls.TextBox
    {
        public static readonly System.Windows.DependencyProperty CultureInfoProperty;
        public static readonly System.Windows.DependencyProperty FormatProperty;
        public static readonly System.Windows.DependencyProperty IsChangeValueByUpDownKeyEnabledProperty;
        public static readonly System.Windows.DependencyProperty IsDecimalAllowedProperty;
        public static readonly System.Windows.DependencyProperty IsNegativeAllowedProperty;
        public static readonly System.Windows.DependencyProperty IsNullValueAllowedProperty;
        public static readonly System.Windows.DependencyProperty MaxValueProperty;
        public static readonly System.Windows.DependencyProperty MinValueProperty;
        public static readonly System.Windows.DependencyProperty NullStringProperty;
        public static readonly System.Windows.DependencyProperty ValueProperty;
        public NumericTextBox() { }
        public System.Globalization.CultureInfo CultureInfo { get; set; }
        public string Format { get; set; }
        public bool IsChangeValueByUpDownKeyEnabled { get; set; }
        public bool IsDecimalAllowed { get; set; }
        public bool IsNegativeAllowed { get; set; }
        public bool IsNullValueAllowed { get; set; }
        public double MaxValue { get; set; }
        public double MinValue { get; set; }
        public string NullString { get; set; }
        public double? Value { get; set; }
        public event System.EventHandler LeftBoundReached;
        public event System.EventHandler RightBoundReached;
        public event System.EventHandler ValueChanged;
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
        protected override void OnPreviewTextInput(System.Windows.Input.TextCompositionEventArgs e) { }
    }
    public class NumericTextBoxAdapterBehavior : Catel.Windows.Interactivity.BehaviorBase<Orc.Controls.NumericTextBox>
    {
        public static readonly System.Windows.DependencyProperty ValueProperty;
        public static readonly System.Windows.DependencyProperty ValueTypeProperty;
        public NumericTextBoxAdapterBehavior() { }
        public object Value { get; set; }
        public System.Type ValueType { get; set; }
        protected virtual object Convert(double? value) { }
        protected virtual double? ConvertBack(object value) { }
        protected override void OnAssociatedObjectLoaded() { }
        protected override void OnAssociatedObjectUnloaded() { }
    }
    [System.Windows.TemplatePart(Name="PART_DecreaseButton", Type=typeof(System.Windows.Controls.Primitives.RepeatButton))]
    [System.Windows.TemplatePart(Name="PART_IncreaseButton", Type=typeof(System.Windows.Controls.Primitives.RepeatButton))]
    [System.Windows.TemplatePart(Name="PART_SpinButton", Type=typeof(Orc.Controls.SpinButton))]
    [System.Windows.TemplatePart(Name="PART_TextBox", Type=typeof(System.Windows.Controls.TextBox))]
    public class NumericUpDown : System.Windows.Controls.Control
    {
        public static readonly System.Windows.DependencyProperty DecimalPlacesProperty;
        public static readonly System.Windows.DependencyProperty IsAutoSelectionActiveProperty;
        public static readonly System.Windows.DependencyProperty IsDecimalPointDynamicProperty;
        public static readonly System.Windows.DependencyProperty IsThousandSeparatorVisibleProperty;
        public static readonly System.Windows.DependencyProperty MajorDeltaProperty;
        public static readonly System.Windows.DependencyProperty MaxDecimalPlacesProperty;
        public static readonly System.Windows.DependencyProperty MaxValueProperty;
        public static readonly System.Windows.DependencyProperty MinDecimalPlacesProperty;
        public static readonly System.Windows.DependencyProperty MinValueProperty;
        public static readonly System.Windows.DependencyProperty MinorDeltaProperty;
        public static readonly System.Windows.DependencyProperty ValueProperty;
        public NumericUpDown() { }
        public int DecimalPlaces { get; set; }
        public bool IsAutoSelectionActive { get; set; }
        public bool IsDecimalPointDynamic { get; set; }
        public bool IsThousandSeparatorVisible { get; set; }
        public double MajorDelta { get; set; }
        public int MaxDecimalPlaces { get; set; }
        public double MaxValue { get; set; }
        public int MinDecimalPlaces { get; set; }
        public double MinValue { get; set; }
        public double MinorDelta { get; set; }
        public Orc.Controls.Number Value { get; set; }
        public event System.EventHandler<System.EventArgs> TextChanged;
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
        protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
    }
    public class OpenFilePicker : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty BaseDirectoryProperty;
        public static readonly System.Windows.DependencyProperty FilterProperty;
        public static readonly System.Windows.DependencyProperty LabelTextProperty;
        public static readonly System.Windows.DependencyProperty LabelWidthProperty;
        public static readonly System.Windows.DependencyProperty SelectedFileProperty;
        public OpenFilePicker() { }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string BaseDirectory { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string Filter { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string LabelText { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public double LabelWidth { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string SelectedFile { get; set; }
        public void InitializeComponent() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class OpenFilePickerViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData BaseDirectoryProperty;
        public static readonly Catel.Data.IPropertyData FilterProperty;
        public static readonly Catel.Data.IPropertyData LabelTextProperty;
        public static readonly Catel.Data.IPropertyData LabelWidthProperty;
        public static readonly Catel.Data.IPropertyData SelectedFileDisplayNameProperty;
        public static readonly Catel.Data.IPropertyData SelectedFileProperty;
        public OpenFilePickerViewModel(Catel.Services.IOpenFileService openFileService, Catel.Services.IProcessService processService) { }
        public string BaseDirectory { get; set; }
        public Catel.MVVM.Command Clear { get; }
        public string Filter { get; set; }
        public string LabelText { get; set; }
        public double LabelWidth { get; set; }
        public Catel.MVVM.Command OpenDirectory { get; }
        public Catel.MVVM.TaskCommand SelectFile { get; }
        public string SelectedFile { get; set; }
        public string SelectedFileDisplayName { get; }
    }
    public class OpenToolCommandExtension : Catel.Windows.Markup.UpdatableMarkupExtension
    {
        public OpenToolCommandExtension(System.Type toolType, System.Type frameworkElementType) { }
        protected Catel.MVVM.Command<object> Command { get; }
        protected virtual System.Windows.FrameworkElement GetAttachmentTarget(object parameter = null) { }
        protected override object ProvideDynamicValue(System.IServiceProvider serviceProvider) { }
    }
    public class PasswordBindBehavior : Catel.Windows.Interactivity.BehaviorBase<System.Windows.Controls.PasswordBox>
    {
        public static readonly System.Windows.DependencyProperty PasswordProperty;
        public PasswordBindBehavior() { }
        public string Password { get; set; }
        protected override void OnAssociatedObjectLoaded() { }
        protected override void OnAssociatedObjectUnloaded() { }
    }
    [System.Windows.TemplatePart(Name="PART_CloseButton", Type=typeof(System.Windows.Controls.Button))]
    [System.Windows.TemplatePart(Name="PART_DragGrip", Type=typeof(System.Windows.FrameworkElement))]
    [System.Windows.TemplatePart(Name="PART_GripDrawing", Type=typeof(System.Windows.Media.GeometryDrawing))]
    [System.Windows.TemplatePart(Name="PART_PinButton", Type=typeof(System.Windows.Controls.Primitives.ToggleButton))]
    public class PinnableToolTip : System.Windows.Controls.ContentControl
    {
        public static readonly System.Windows.DependencyProperty AllowCloseByUserProperty;
        public static readonly System.Windows.DependencyProperty GripColorProperty;
        public static readonly System.Windows.DependencyProperty HorizontalOffsetProperty;
        public static readonly System.Windows.DependencyProperty IsPinnedProperty;
        public static readonly System.Windows.DependencyProperty OpenLinkCommandProperty;
        public static readonly System.Windows.DependencyProperty ResizeModeProperty;
        public static readonly System.Windows.DependencyProperty VerticalOffsetProperty;
        public PinnableToolTip() { }
        public bool AllowCloseByUser { get; set; }
        public System.Windows.Media.Color GripColor { get; set; }
        public double HorizontalOffset { get; set; }
        public bool IsOpen { get; }
        public bool IsPinned { get; set; }
        public System.Windows.Input.ICommand OpenLinkCommand { get; set; }
        public System.Windows.UIElement Owner { get; set; }
        public System.Windows.ResizeMode ResizeMode { get; set; }
        public double VerticalOffset { get; set; }
        public event System.EventHandler<System.EventArgs> IsOpenChanged;
        public event System.EventHandler<System.EventArgs> IsPinnedChanged;
        public void BringToFront() { }
        public System.Windows.Point GetPosition() { }
        public void Hide() { }
        public void IgnoreTimerStartupWhenMouseLeave(bool value) { }
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        public void SetUserDefinedAdorner(System.Windows.UIElement element) { }
        public void SetupTimer(int initialShowDelay, int showDuration) { }
        public void Show() { }
        public void StartTimer() { }
        public void StopTimer(bool reset = true) { }
    }
    public static class PinnableToolTipService
    {
        public static readonly System.Windows.DependencyProperty InitialShowDelayProperty;
        public static readonly System.Windows.DependencyProperty IsToolTipOwnerProperty;
        public static readonly System.Windows.DependencyProperty PlacementProperty;
        public static readonly System.Windows.DependencyProperty PlacementTargetProperty;
        public static readonly System.Windows.DependencyProperty ShowDurationProperty;
        public static readonly System.Windows.DependencyProperty ToolTipProperty;
        public static int GetInitialShowDelay(System.Windows.DependencyObject element) { }
        public static bool GetIsToolTipOwner(System.Windows.DependencyObject element) { }
        public static System.Windows.Controls.Primitives.PlacementMode GetPlacement(System.Windows.DependencyObject element) { }
        public static System.Windows.UIElement GetPlacementTarget(System.Windows.DependencyObject element) { }
        public static int GetShowDuration(System.Windows.DependencyObject element) { }
        public static object GetToolTip(System.Windows.DependencyObject element) { }
        public static void SetInitialShowDelay(System.Windows.DependencyObject element, int value) { }
        public static void SetIsToolTipOwner(System.Windows.DependencyObject element, bool value) { }
        public static void SetPlacement(System.Windows.DependencyObject element, System.Windows.Controls.Primitives.PlacementMode value) { }
        public static void SetPlacementTarget(System.Windows.DependencyObject element, System.Windows.UIElement value) { }
        public static void SetShowDuration(System.Windows.DependencyObject element, int value) { }
        public static void SetToolTip(System.Windows.DependencyObject element, object value) { }
    }
    public class PredefinedColor : System.IEquatable<Orc.Controls.PredefinedColor>
    {
        public string Name { get; }
        public System.Windows.Media.Color Value { get; }
        public static System.Collections.Generic.List<Orc.Controls.PredefinedColor> All { get; }
        public static System.Collections.Generic.List<Orc.Controls.PredefinedColor> AllThemeColors { get; }
        public bool Equals(Orc.Controls.PredefinedColor other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static string GetColorName(System.Windows.Media.Color color) { }
        public static Orc.Controls.PredefinedColor GetPredefinedColor(System.Windows.Media.Color color) { }
        public static bool IsPredefined(System.Windows.Media.Color color) { }
        public static bool operator !=(Orc.Controls.PredefinedColor color1, Orc.Controls.PredefinedColor color2) { }
        public static bool operator ==(Orc.Controls.PredefinedColor color1, Orc.Controls.PredefinedColor color2) { }
    }
    public class PredefinedColorItem : System.Windows.Controls.Control
    {
        public static readonly System.Windows.DependencyProperty ColorProperty;
        public static readonly System.Windows.DependencyProperty TextProperty;
        public PredefinedColorItem() { }
        public PredefinedColorItem(System.Windows.Media.Color color, string text) { }
        public System.Windows.Media.Color Color { get; set; }
        public string Text { get; set; }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class PredefinedColorItemPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.PredefinedColorItem>
    {
        public PredefinedColorItemPeer(Orc.Controls.PredefinedColorItem owner) { }
    }
    public static class PredefinedDateRanges
    {
        public static Orc.Controls.DateRange LastMonth { get; }
        public static Orc.Controls.DateRange LastWeek { get; }
        public static Orc.Controls.DateRange ThisMonth { get; }
        public static Orc.Controls.DateRange ThisWeek { get; }
        public static Orc.Controls.DateRange Today { get; }
        public static Orc.Controls.DateRange Yesterday { get; }
    }
    [System.Windows.TemplatePart(Name="PART_LowerSlider", Type=typeof(System.Windows.Controls.Slider))]
    [System.Windows.TemplatePart(Name="PART_SelectedRange", Type=typeof(System.Windows.Shapes.Rectangle))]
    [System.Windows.TemplatePart(Name="PART_TrackBackground", Type=typeof(System.Windows.Controls.Border))]
    [System.Windows.TemplatePart(Name="PART_UpperSlider", Type=typeof(System.Windows.Controls.Slider))]
    public class RangeSlider : System.Windows.Controls.Primitives.RangeBase
    {
        public static readonly System.Windows.DependencyProperty HighlightSelectedRangeProperty;
        public static readonly System.Windows.RoutedEvent LowerValueChangedEvent;
        public static readonly System.Windows.DependencyProperty LowerValueProperty;
        public static readonly System.Windows.DependencyProperty OrientationProperty;
        public static readonly System.Windows.RoutedEvent UpperValueChangedEvent;
        public static readonly System.Windows.DependencyProperty UpperValueProperty;
        public RangeSlider() { }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Behavior")]
        public bool HighlightSelectedRange { get; set; }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Behavior")]
        public double LowerValue { get; set; }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Behavior")]
        public System.Windows.Controls.Orientation Orientation { get; set; }
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.Category("Behavior")]
        public double UpperValue { get; set; }
        [System.ComponentModel.Category("Behavior")]
        public event System.Windows.RoutedPropertyChangedEventHandler<double> LowerValueChanged;
        [System.ComponentModel.Category("Behavior")]
        public event System.Windows.RoutedPropertyChangedEventHandler<double> UpperValueChanged;
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    }
    public class ResizingAdorner : System.Windows.Documents.Adorner
    {
        protected override int VisualChildrenCount { get; }
        protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { }
        protected override System.Windows.Media.Visual GetVisualChild(int index) { }
        public static Orc.Controls.ResizingAdorner Attach(System.Windows.FrameworkElement element) { }
        public static void Detach(Orc.Controls.ResizingAdorner adorner) { }
    }
    public static class RichTextBoxExtensions
    {
        public static string GetInlineText(this System.Windows.Controls.RichTextBox richTextBox) { }
    }
    public class RichTextBoxParagraph : System.Windows.Documents.Paragraph
    {
        public RichTextBoxParagraph(Catel.Logging.LogEntry logEntry) { }
        public Catel.Logging.LogEntry LogEntry { get; }
    }
    public static class RichTextBoxParagraphExtensions
    {
        public static void SetData(this Orc.Controls.RichTextBoxParagraph paragraph, bool showTimestamp = true, bool showThreadId = true, bool showMultilineMessagesExpanded = false) { }
    }
    public class SaveFilePicker : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty FilterProperty;
        public static readonly System.Windows.DependencyProperty InitialDirectoryProperty;
        public static readonly System.Windows.DependencyProperty InitialFileNameProperty;
        public static readonly System.Windows.DependencyProperty LabelTextProperty;
        public static readonly System.Windows.DependencyProperty LabelWidthProperty;
        public static readonly System.Windows.DependencyProperty SelectedFileProperty;
        public SaveFilePicker() { }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string Filter { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string InitialDirectory { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string InitialFileName { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string LabelText { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public double LabelWidth { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public string SelectedFile { get; set; }
        public void InitializeComponent() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class SaveFilePickerViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData? FilterProperty;
        public static readonly Catel.Data.IPropertyData? InitialDirectoryProperty;
        public static readonly Catel.Data.IPropertyData? InitialFileNameProperty;
        public static readonly Catel.Data.IPropertyData? LabelTextProperty;
        public static readonly Catel.Data.IPropertyData? LabelWidthProperty;
        public static readonly Catel.Data.IPropertyData? SelectedFileProperty;
        public SaveFilePickerViewModel(Catel.Services.ISaveFileService saveFileService, Catel.Services.IProcessService processService) { }
        public Catel.MVVM.Command Clear { get; }
        public string? Filter { get; set; }
        public string? InitialDirectory { get; set; }
        public string? InitialFileName { get; set; }
        public string? LabelText { get; set; }
        public double LabelWidth { get; set; }
        public Catel.MVVM.Command OpenDirectory { get; }
        public Catel.MVVM.TaskCommand SelectFile { get; }
        public string? SelectedFile { get; set; }
    }
    public enum ScrollMode
    {
        OnlyManual = 0,
        AutoScrollPriority = 1,
        ManualScrollPriority = 2,
    }
    public class SelectTextOnLoaded : Catel.Windows.Interactivity.BehaviorBase<System.Windows.Controls.TextBox>
    {
        public SelectTextOnLoaded() { }
        protected override void OnAssociatedObjectLoaded() { }
        protected override void OnAssociatedObjectUnloaded() { }
    }
    public class ShowStepNumberVisibilityConverter : Catel.MVVM.Converters.VisibilityConverterBase
    {
        public ShowStepNumberVisibilityConverter() { }
        protected override bool IsVisible(object? value, System.Type targetType, object? parameter) { }
    }
    [System.Windows.TemplatePart(Name="PART_DecreaseButton", Type=typeof(System.Windows.Controls.Primitives.RepeatButton))]
    [System.Windows.TemplatePart(Name="PART_IncreaseButton", Type=typeof(System.Windows.Controls.Primitives.RepeatButton))]
    public class SpinButton : System.Windows.Controls.Control
    {
        public static readonly System.Windows.RoutedEvent CanceledEvent;
        public static readonly System.Windows.DependencyProperty CommandParameterProperty;
        public static readonly System.Windows.DependencyProperty DecreaseProperty;
        public static readonly System.Windows.RoutedEvent DecreasedEvent;
        public static readonly System.Windows.DependencyProperty IncreaseProperty;
        public static readonly System.Windows.RoutedEvent IncreasedEvent;
        public SpinButton() { }
        public object CommandParameter { get; set; }
        public System.Windows.Input.ICommand Decrease { get; set; }
        public System.Windows.Input.ICommand Increase { get; set; }
        public event System.Windows.RoutedEventHandler Canceled;
        public event System.Windows.RoutedEventHandler Decreased;
        public event System.Windows.RoutedEventHandler Increased;
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
        protected override void OnPreviewMouseRightButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
    }
    public class StackGrid : System.Windows.Controls.Grid
    {
        public StackGrid() { }
    }
    public class StaggeredPanel : System.Windows.Controls.Panel
    {
        public static readonly System.Windows.DependencyProperty ColumnSpacingProperty;
        public static readonly System.Windows.DependencyProperty DesiredColumnWidthProperty;
        public static readonly System.Windows.DependencyProperty PaddingProperty;
        public static readonly System.Windows.DependencyProperty RowSpacingProperty;
        public StaggeredPanel() { }
        public double ColumnSpacing { get; set; }
        public double DesiredColumnWidth { get; set; }
        public System.Windows.Thickness Padding { get; set; }
        public double RowSpacing { get; set; }
        protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { }
        protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public sealed class StepBar : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty ItemsProperty;
        public static readonly System.Windows.DependencyProperty OrientationProperty;
        public static readonly System.Windows.DependencyProperty SelectedItemProperty;
        public StepBar() { }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public System.Collections.Generic.IList<Orc.Controls.IStepBarItem>? Items { get; set; }
        public System.Windows.Controls.Orientation Orientation { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public Orc.Controls.IStepBarItem? SelectedItem { get; set; }
        public void InitializeComponent() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnLoaded(System.EventArgs e) { }
        protected override void OnViewModelPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    }
    public static class StepBarConfiguration
    {
        public static System.TimeSpan AnimationDuration { get; set; }
    }
    public sealed class StepBarItem : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty OrientationProperty;
        public StepBarItem() { }
        public System.Windows.Controls.Orientation Orientation { get; set; }
        public void InitializeComponent() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnLoaded(System.EventArgs e) { }
    }
    public class StepBarItemBase : Catel.Data.ModelBase, Orc.Controls.IStepBarItem
    {
        public static readonly Catel.Data.IPropertyData? DescriptionProperty;
        public static readonly Catel.Data.IPropertyData? NumberProperty;
        public static readonly Catel.Data.IPropertyData? StateProperty;
        public static readonly Catel.Data.IPropertyData? TitleProperty;
        public StepBarItemBase() { }
        public System.Windows.Input.ICommand? Command { get; set; }
        public string? Description { get; set; }
        public int Number { get; set; }
        public Orc.Controls.StepBarItemStates State { get; set; }
        public string? Title { get; set; }
    }
    [System.Flags]
    public enum StepBarItemStates : short
    {
        None = 0,
        IsVisited = 1,
        IsOptional = 2,
        IsCurrent = 4,
        IsBeforeCurrent = 8,
        IsLast = 16,
    }
    public class StepBarItemViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData ItemProperty;
        public StepBarItemViewModel(Orc.Controls.IStepBarItem stepBarItem) { }
        public Orc.Controls.IStepBarItem Item { get; }
    }
    public class StepBarViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData ItemsProperty;
        public static readonly Catel.Data.IPropertyData SelectedItemProperty;
        public StepBarViewModel() { }
        public System.Collections.Generic.IList<Orc.Controls.IStepBarItem> Items { get; set; }
        public Orc.Controls.IStepBarItem? SelectedItem { get; set; }
        protected override System.Threading.Tasks.Task InitializeAsync() { }
    }
    public class StepToOpacityConverter : Catel.MVVM.Converters.ValueConverterBase
    {
        public StepToOpacityConverter() { }
        protected override object Convert(object value, System.Type targetType, object parameter) { }
    }
    public static class StringExtensions
    {
        public static string ConstructWildcardRegex(this string pattern) { }
        public static string ExtractRegexString(this string filter) { }
        public static string GetRegexStringFromSearchPattern(this string pattern) { }
        public static bool IsValidRegexPattern(this string pattern) { }
        public static System.Windows.Documents.Inline ToInline(this string text) { }
        public static System.IO.Stream ToStream(this string s) { }
    }
    public class SuggestionListService : Orc.Controls.ISuggestionListService
    {
        public SuggestionListService() { }
        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> GetSuggestionList(System.DateTime dateTime, Orc.Controls.DateTimePart editablePart, Orc.Controls.DateTimeFormatInfo dateTimeFormatInfo) { }
    }
    [System.Windows.TemplatePart(Name="PART_ItemsHolder", Type=typeof(System.Windows.Controls.Panel))]
    public class TabControl : System.Windows.Controls.TabControl
    {
        public static readonly System.Windows.DependencyProperty LoadTabItemsProperty;
        public TabControl() { }
        public bool IsLazyLoading { get; }
        public Orc.Controls.LoadTabItemsBehavior LoadTabItems { get; set; }
        protected new System.Windows.Controls.TabItem GetSelectedTabItem() { }
        public virtual void LoadTabItem(int index) { }
        public virtual void LoadTabItem(System.Windows.Controls.ContentPresenter tabItem) { }
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnItemsChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    }
    public class TabControlItemData
    {
        public TabControlItemData(object container, object content, System.Windows.DataTemplate contentTemplate, object item) { }
        public object Container { get; }
        public object Content { get; }
        public System.Windows.DataTemplate ContentTemplate { get; }
        public object Item { get; }
        public System.Windows.Controls.TabItem TabItem { get; }
    }
    public static class TextBoxExtensions { }
    public class TextInputDialogResult
    {
        public TextInputDialogResult() { }
        public bool? Result { get; set; }
        public string? Text { get; set; }
    }
    public class TimeAdjustment
    {
        public TimeAdjustment() { }
        public string Name { get; set; }
        public Orc.Controls.TimeAdjustmentStrategy Strategy { get; set; }
    }
    public class TimeAdjustmentCollectionConverter : Catel.MVVM.Converters.ValueConverterBase
    {
        public TimeAdjustmentCollectionConverter() { }
        protected override object Convert(object value, System.Type targetType, object parameter) { }
    }
    public class TimeAdjustmentConverter : Catel.MVVM.Converters.ValueConverterBase
    {
        public TimeAdjustmentConverter() { }
        protected override object Convert(object value, System.Type targetType, object parameter) { }
        protected override object ConvertBack(object value, System.Type targetType, object parameter) { }
    }
    public class TimeAdjustmentProvider : Orc.Controls.ITimeAdjustmentProvider
    {
        public TimeAdjustmentProvider() { }
        public Orc.Controls.TimeAdjustment GetTimeAdjustment(Orc.Controls.TimeAdjustmentStrategy strategy) { }
    }
    public enum TimeAdjustmentStrategy
    {
        AdjustEndTime = 0,
        AdjustDuration = 1,
    }
    public abstract class TimeBasedCalloutWatcherBase : Orc.Controls.CalloutWatcherBase
    {
        public TimeBasedCalloutWatcherBase(Orc.Controls.ICalloutManager calloutManager, Catel.Configuration.IConfigurationService configurationService) { }
        public abstract System.TimeSpan Delay { get; }
        public System.DateTime End { get; }
        public System.DateTime Start { get; set; }
        protected virtual void Subscribe(Orc.Controls.ICalloutManager calloutManager) { }
    }
    public class TimePicker : System.Windows.Controls.ContentControl
    {
        public const double HourIndicatorRatio = 0.7D;
        public const double HourTickRatio = 0.2D;
        public const double MinuteIndicatorRatio = 0.95D;
        public const double MinuteTickRatio = 0.1D;
        public static readonly System.Windows.DependencyProperty AmPmValueProperty;
        public static readonly System.Windows.DependencyProperty ClockBorderThicknessProperty;
        public static readonly System.Windows.DependencyProperty HourBrushProperty;
        public static readonly System.Windows.DependencyProperty HourThicknessProperty;
        public static readonly System.Windows.DependencyProperty HourTickBrushProperty;
        public static readonly System.Windows.DependencyProperty HourTickThicknessProperty;
        public static readonly System.Windows.DependencyProperty Is24HourFormatProperty;
        public static readonly System.Windows.DependencyProperty MinuteBrushProperty;
        public static readonly System.Windows.DependencyProperty MinuteThicknessProperty;
        public static readonly System.Windows.DependencyProperty MinuteTickBrushProperty;
        public static readonly System.Windows.DependencyProperty MinuteTickThicknessProperty;
        public static readonly System.Windows.DependencyProperty ShowNumbersProperty;
        public static readonly System.Windows.DependencyProperty TimeValueProperty;
        public TimePicker() { }
        public Orc.Controls.Enums.Meridiem AmPmValue { get; set; }
        public double ClockBorderThickness { get; set; }
        public System.Windows.Media.Brush HourBrush { get; set; }
        public double HourThickness { get; set; }
        public System.Windows.Media.Brush HourTickBrush { get; set; }
        public double HourTickThickness { get; set; }
        public bool Is24HourFormat { get; set; }
        public System.Windows.Media.Brush MinuteBrush { get; set; }
        public double MinuteThickness { get; set; }
        public System.Windows.Media.Brush MinuteTickBrush { get; set; }
        public double MinuteTickThickness { get; set; }
        public bool ShowNumbers { get; set; }
        public System.TimeSpan TimeValue { get; set; }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
    }
    public enum TimeSpanPart
    {
        Days = 0,
        Hours = 1,
        Minutes = 2,
        Seconds = 3,
    }
    public static class TimeSpanPartExtensions
    {
        public static System.TimeSpan CreateTimeSpan(this Orc.Controls.TimeSpanPart timeSpanPart, double value) { }
        public static string GetTimeSpanPartName(this Orc.Controls.TimeSpanPart timeSpanPart) { }
        public static double GetTimeSpanPartValue(this System.TimeSpan value, Orc.Controls.TimeSpanPart timeSpanPart) { }
    }
    [System.Windows.TemplatePart(Name="PART_DaysAbbreviationTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_DaysHoursSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_DaysNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_EditedUnitTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_EditorNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_HoursAbbreviationTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_HoursMinutesSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_HoursNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_MinutesAbbreviationTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_MinutesNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    [System.Windows.TemplatePart(Name="PART_MinutesSecondsSeparatorTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_NumericTBEditorContainerBorder", Type=typeof(System.Windows.Controls.Border))]
    [System.Windows.TemplatePart(Name="PART_SecondsAbbreviationTextBlock", Type=typeof(System.Windows.Controls.TextBlock))]
    [System.Windows.TemplatePart(Name="PART_SecondsNumericTextBox", Type=typeof(Orc.Controls.NumericTextBox))]
    public class TimeSpanPicker : System.Windows.Controls.Control
    {
        public static readonly System.Windows.DependencyProperty IsReadOnlyProperty;
        public static readonly System.Windows.DependencyProperty ValueProperty;
        public TimeSpanPicker() { }
        public bool IsReadOnly { get; set; }
        public System.TimeSpan? Value { get; set; }
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnIsKeyboardFocusedChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
        protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
    }
    public static class TreeViewItemExtensions
    {
        public static int GetDepth(this System.Windows.Controls.TreeViewItem item) { }
    }
    public static class TypeExtensions
    {
        public static object ChangeTypeSafe(this System.Type convertToType, double dValue) { }
        public static System.Type FindGenericTypeImplementation<TBaseType>(this System.Type singleGenericTypeArgument, System.Reflection.Assembly assembly = null) { }
        public static System.Array GetEnumValues(this System.Type enumType) { }
        public static T[] GetEnumValues<T>() { }
        public static bool IsFloatingPointType(this System.Type type) { }
        public static bool IsInNumberRange(this System.Type type, double checkedValue) { }
        [return: System.Runtime.CompilerServices.TupleElementNames(new string[] {
                "Min",
                "Max"})]
        public static System.ValueTuple<double, double>? TryGetNumberRange(this System.Type type) { }
    }
    public sealed class ValidationContextTree : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty FilterProperty;
        public static readonly System.Windows.DependencyProperty IsExpandedByDefaultProperty;
        public static readonly System.Windows.DependencyProperty NodesProperty;
        public static readonly System.Windows.DependencyProperty ShowErrorsProperty;
        public static readonly System.Windows.DependencyProperty ShowWarningsProperty;
        public static readonly System.Windows.DependencyProperty ValidationContextProperty;
        public ValidationContextTree() { }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.ViewToViewModel)]
        public string Filter { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.ViewToViewModel)]
        public bool IsExpandedByDefault { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.ViewModelToView)]
        public System.Collections.Generic.IEnumerable<Orc.Controls.IValidationContextTreeNode> Nodes { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.ViewToViewModel)]
        public bool ShowErrors { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.ViewToViewModel)]
        public bool ShowWarnings { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.ViewToViewModel)]
        public Catel.Data.IValidationContext ValidationContext { get; set; }
        public void InitializeComponent() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class ValidationContextTreeNode : Catel.Data.ChildAwareModelBase, Orc.Controls.IValidationContextTreeNode, System.IComparable
    {
        public static readonly Catel.Data.IPropertyData DisplayNameProperty;
        public static readonly Catel.Data.IPropertyData IsExpandedProperty;
        public static readonly Catel.Data.IPropertyData IsVisibleProperty;
        public static readonly Catel.Data.IPropertyData ResultTypeProperty;
        protected ValidationContextTreeNode(bool isExpanded) { }
        public Catel.Collections.FastObservableCollection<Orc.Controls.ValidationContextTreeNode> Children { get; }
        public string DisplayName { get; set; }
        public bool IsExpanded { get; set; }
        public bool IsVisible { get; set; }
        public Catel.Data.ValidationResultType? ResultType { get; set; }
        public void ApplyFilter(bool showErrors, bool showWarnings, string filter) { }
        public virtual int CompareTo(Orc.Controls.ValidationContextTreeNode node) { }
        public int CompareTo(object obj) { }
        protected override void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    }
    public class ValidationContextTreeViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData FilterProperty;
        public static readonly Catel.Data.IPropertyData IsExpandedByDefaultProperty;
        public static readonly Catel.Data.IPropertyData ShowErrorsProperty;
        public static readonly Catel.Data.IPropertyData ShowWarningsProperty;
        public static readonly Catel.Data.IPropertyData ValidationContextProperty;
        public ValidationContextTreeViewModel(Orc.Controls.IValidationNamesService validationNamesService) { }
        public string Filter { get; set; }
        public bool IsExpandedByDefault { get; set; }
        public System.Collections.Generic.IEnumerable<Orc.Controls.IValidationContextTreeNode> Nodes { get; }
        public bool ShowErrors { get; set; }
        public bool ShowWarnings { get; set; }
        public Catel.Data.IValidationContext? ValidationContext { get; set; }
        public Catel.Collections.FastObservableCollection<Orc.Controls.ValidationResultTagNode> ValidationResultTags { get; }
        protected override System.Threading.Tasks.Task CloseAsync() { }
        protected override System.Threading.Tasks.Task InitializeAsync() { }
        protected override void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    }
    public sealed class ValidationContextView : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty IsExpandedAllOnStartupProperty;
        public static readonly System.Windows.DependencyProperty ShowButtonsProperty;
        public static readonly System.Windows.DependencyProperty ShowFilterBoxProperty;
        public static readonly System.Windows.DependencyProperty ValidationContextProperty;
        public ValidationContextView() { }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool IsExpandedAllOnStartup { get; set; }
        public bool ShowButtons { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public bool ShowFilterBox { get; set; }
        [Catel.MVVM.Views.ViewToViewModel("", MappingType=Catel.MVVM.Views.ViewToViewModelMappingType.TwoWayViewWins)]
        public Catel.Data.IValidationContext ValidationContext { get; set; }
        public void InitializeComponent() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class ValidationContextViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData ErrorsCountProperty;
        public static readonly Catel.Data.IPropertyData FilterProperty;
        public static readonly Catel.Data.IPropertyData IsExpandedAllOnStartupProperty;
        public static readonly Catel.Data.IPropertyData IsExpandedProperty;
        public static readonly Catel.Data.IPropertyData NodesProperty;
        public static readonly Catel.Data.IPropertyData ShowErrorsProperty;
        public static readonly Catel.Data.IPropertyData ShowFilterBoxProperty;
        public static readonly Catel.Data.IPropertyData ShowWarningsProperty;
        public static readonly Catel.Data.IPropertyData ValidationContextProperty;
        public static readonly Catel.Data.IPropertyData ValidationResultsProperty;
        public static readonly Catel.Data.IPropertyData WarningsCountProperty;
        public ValidationContextViewModel(Catel.Services.IProcessService processService) { }
        public ValidationContextViewModel(Catel.Data.ValidationContext validationContext, Catel.Services.IProcessService processService, Catel.Services.IDispatcherService dispatcherService) { }
        public Catel.MVVM.Command CollapseAll { get; }
        public Catel.MVVM.Command Copy { get; }
        public int ErrorsCount { get; }
        public Catel.MVVM.Command ExpandAll { get; }
        public string Filter { get; set; }
        public bool IsCollapsed { get; }
        public bool IsExpanded { get; }
        public bool IsExpandedAllOnStartup { get; set; }
        public System.Collections.Generic.IEnumerable<Orc.Controls.IValidationContextTreeNode> Nodes { get; set; }
        public Catel.MVVM.Command Open { get; }
        public bool ShowErrors { get; set; }
        public bool ShowFilterBox { get; set; }
        public bool ShowWarnings { get; set; }
        public Catel.Data.IValidationContext? ValidationContext { get; set; }
        public System.Collections.Generic.List<Catel.Data.IValidationResult> ValidationResults { get; }
        public int WarningsCount { get; }
        protected override System.Threading.Tasks.Task InitializeAsync() { }
        protected override void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    }
    public class ValidationNamesService : Orc.Controls.IValidationNamesService
    {
        public ValidationNamesService(Catel.Services.ILanguageService languageService) { }
        public void Clear() { }
        protected virtual Orc.Controls.ValidationNamesService.TagDetails ExtractTagData(Catel.Data.IValidationResult validationResult) { }
        protected virtual int? ExtractTagLine(Catel.Data.IValidationResult validationResult) { }
        protected virtual string ExtractTagName(Catel.Data.IValidationResult validationResult) { }
        public virtual System.Collections.Generic.IEnumerable<Catel.Data.IValidationResult> GetCachedResultsByTagName(string tagName) { }
        public virtual string GetDisplayName(Catel.Data.IValidationResult validationResult) { }
        public int? GetLineNumber(Catel.Data.IValidationResult validationResult) { }
        public string GetTagName(Catel.Data.IValidationResult validationResult) { }
        protected class TagDetails
        {
            public TagDetails() { }
            public int? ColumnIndex { get; set; }
            public string ColumnName { get; set; }
            public int? Line { get; set; }
        }
    }
    public class ValidationResultNode : Orc.Controls.ValidationContextTreeNode
    {
        public static readonly Catel.Data.IPropertyData LineNumberProperty;
        public ValidationResultNode(Catel.Data.IValidationResult validationResult, Orc.Controls.IValidationNamesService validationNamesService, bool isExpanded) { }
        public int? LineNumber { get; }
    }
    public class ValidationResultTagNode : Orc.Controls.ValidationContextTreeNode
    {
        public ValidationResultTagNode(string tagName, bool isExpanded) { }
        public string TagName { get; }
        public override int CompareTo(Orc.Controls.ValidationContextTreeNode node) { }
        protected override void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
        protected override void OnPropertyObjectCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    }
    public class ValidationResultTypeNode : Orc.Controls.ValidationContextTreeNode
    {
        public ValidationResultTypeNode(Catel.Data.ValidationResultType resultType, System.Collections.Generic.IEnumerable<Catel.Data.IValidationResult> validationResults, Orc.Controls.IValidationNamesService validationNamesService, bool isExpanded) { }
    }
    public class ValidationResultTypeToColorMultiValueConverter : System.Windows.Data.IMultiValueConverter
    {
        public ValidationResultTypeToColorMultiValueConverter() { }
        public System.Windows.Media.SolidColorBrush DefaultBrush { get; set; }
        public System.Windows.Media.SolidColorBrush ErrorBrush { get; set; }
        public System.Windows.Media.SolidColorBrush WarningBrush { get; set; }
        public object Convert(object[] values, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class VisualTargetPresentationSource : System.Windows.PresentationSource
    {
        public VisualTargetPresentationSource(System.Windows.Media.HostVisual hostVisual) { }
        public override bool IsDisposed { get; }
        public override System.Windows.Media.Visual RootVisual { get; set; }
        protected override System.Windows.Media.CompositionTarget GetCompositionTargetCore() { }
    }
    [System.Windows.Markup.ContentProperty("Child")]
    public class VisualWrapper : System.Windows.FrameworkElement
    {
        public VisualWrapper() { }
        public System.Windows.Media.Visual Child { get; set; }
        protected override int VisualChildrenCount { get; }
        protected override System.Windows.Media.Visual GetVisualChild(int index) { }
    }
    [System.Windows.TemplatePart(Name="PART_WatermarkHost", Type=typeof(System.Windows.Controls.ContentPresenter))]
    public class WatermarkTextBox : System.Windows.Controls.TextBox
    {
        public static readonly System.Windows.DependencyProperty SelectAllOnGotFocusProperty;
        public static readonly System.Windows.DependencyProperty WatermarkProperty;
        public static readonly System.Windows.DependencyProperty WatermarkTemplateProperty;
        public WatermarkTextBox() { }
        public bool SelectAllOnGotFocus { get; set; }
        public object Watermark { get; set; }
        public System.Windows.DataTemplate WatermarkTemplate { get; set; }
        public override void OnApplyTemplate() { }
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
        protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
        protected override void OnPreviewMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
    }
    public static class WindowExtensions
    {
        public static void CenterWindowToParent(this System.Windows.Window window) { }
        public static void CenterWindowToSize(this System.Windows.Window window, System.Windows.Rect parentRect) { }
        public static void LoadWindowSize(this System.Windows.Window window, bool restoreWindowState) { }
        public static void LoadWindowSize(this System.Windows.Window window, string? tag = null, bool restoreWindowState = false, bool restoreWindowPosition = true) { }
        public static void SaveWindowSize(this System.Windows.Window window, string? tag = null) { }
    }
    public class WrapPanel : System.Windows.Controls.Panel
    {
        public WrapPanel() { }
        protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { }
        protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { }
    }
}
namespace Orc.Controls.Automation
{
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.AlignmentGrid))]
    public class AlignmentGrid : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.AlignmentGridModel>
    {
        public AlignmentGrid(System.Windows.Automation.AutomationElement element) { }
    }
    public class AlignmentGridAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.AlignmentGrid>
    {
        public AlignmentGridAutomationPeer(Orc.Controls.AlignmentGrid owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class AlignmentGridModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData HorizontalStepProperty;
        public static readonly Catel.Data.IPropertyData LineBrushProperty;
        public static readonly Catel.Data.IPropertyData VerticalStepProperty;
        public AlignmentGridModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public double HorizontalStep { get; set; }
        public System.Windows.Media.Brush LineBrush { get; set; }
        public double VerticalStep { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.AnimatedGif))]
    public class AnimatedGif : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.AnimatedGifModel>
    {
        public AnimatedGif(System.Windows.Automation.AutomationElement element) { }
    }
    public class AnimatedGifAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.AnimatedGif>
    {
        public AnimatedGifAutomationPeer(Orc.Controls.AnimatedGif owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class AnimatedGifModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData GifSourceProperty;
        public AnimatedGifModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public string GifSource { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.AnimatingTextBlock))]
    public class AnimatingTextBlock : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.AnimatingTextBlockModel>
    {
        public AnimatingTextBlock(System.Windows.Automation.AutomationElement element) { }
    }
    public class AnimatingTextBlockAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.AnimatingTextBlock>
    {
        public AnimatingTextBlockAutomationPeer(Orc.Controls.AnimatingTextBlock owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class AnimatingTextBlockModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData TextProperty;
        public AnimatingTextBlockModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public string Text { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.BindableRichTextBox))]
    public class BindableRichTextBox : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.BindableRichTextBoxModel>
    {
        public BindableRichTextBox(System.Windows.Automation.AutomationElement element) { }
    }
    public class BindableRichTextBoxAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.BindableRichTextBox>
    {
        public BindableRichTextBoxAutomationPeer(Orc.Controls.BindableRichTextBox owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class BindableRichTextBoxModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData AutoScrollToEndProperty;
        public static readonly Catel.Data.IPropertyData BindableDocumentProperty;
        public BindableRichTextBoxModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public bool AutoScrollToEnd { get; set; }
        public System.Windows.Documents.FlowDocument BindableDocument { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.BusyIndicator))]
    public class BusyIndicator : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.BusyIndicatorModel>
    {
        public BusyIndicator(System.Windows.Automation.AutomationElement element) { }
    }
    public class BusyIndicatorAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.BusyIndicator>
    {
        public BusyIndicatorAutomationPeer(Orc.Controls.BusyIndicator owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class BusyIndicatorModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData ForegroundProperty;
        public static readonly Catel.Data.IPropertyData IgnoreUnloadedEventCountProperty;
        public BusyIndicatorModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public System.Windows.Media.SolidColorBrush Foreground { get; set; }
        public int IgnoreUnloadedEventCount { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.ColorBoard))]
    public class ColorBoard : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.ColorBoardModel, Orc.Controls.Automation.ColorBoardMap>
    {
        public ColorBoard(System.Windows.Automation.AutomationElement element) { }
        public System.Windows.Media.Color ArgbColor { get; set; }
        public System.Windows.Media.Color ArgbColorAlt { get; set; }
        public System.Collections.Generic.List<string> AvailableColorNames { get; }
        public string ColorName { get; set; }
        public System.Windows.Media.Color HsvColor { get; set; }
        public string PredefinedColorName { get; set; }
        public System.Collections.Generic.IReadOnlyList<Orc.Controls.Automation.PredefinedColorItem> RecentColors { get; }
        public System.Windows.Media.Color? SelectedRecentColor { get; set; }
        public System.Windows.Media.Color? SelectedThemeColor { get; set; }
        public System.Collections.Generic.IReadOnlyList<Orc.Controls.Automation.PredefinedColorItem> ThemeColors { get; }
        public event System.EventHandler<System.EventArgs> CancelClicked;
        public event System.EventHandler<System.EventArgs> DoneClicked;
        public bool Apply() { }
        public bool Cancel() { }
        public void SetHsvColor(System.Windows.Media.Color color) { }
    }
    public class ColorBoardAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.ColorBoard>
    {
        public ColorBoardAutomationPeer(Orc.Controls.ColorBoard owner) { }
        [Orc.Automation.AutomationMethod]
        public System.Windows.Point GetColorPoint(System.Windows.Media.Color color) { }
        [Orc.Automation.AutomationMethod]
        public System.Windows.Rect GetHsvCanvasBoundingRect() { }
        [Orc.Automation.AutomationMethod]
        public System.Windows.Point GetHsvColorEllipsePosition() { }
        [Orc.Automation.AutomationMethod]
        public System.Windows.Point GetSV() { }
    }
    public class ColorBoardMap : Orc.Automation.AutomationBase
    {
        public static string AEditId;
        public static string ASliderId;
        public static string BEditId;
        public static string BSliderId;
        public static string CancelButtonId;
        public static string ColorComboBoxId;
        public static string ColorEditId;
        public static string GEditId;
        public static string GSliderId;
        public static string HSVSliderId;
        public static string REditId;
        public static string RSliderId;
        public static string RecentColorsListBoxId;
        public static string SelectButtonId;
        public static string TabId;
        public static string ThemeColorsListBoxId;
        public ColorBoardMap(Orc.Controls.Automation.ColorBoard target) { }
        public Orc.Automation.Controls.Edit AEdit { get; }
        public Orc.Automation.Controls.Slider ASlider { get; }
        public Orc.Automation.Controls.Edit BEdit { get; }
        public Orc.Automation.Controls.Slider BSlider { get; }
        public override Orc.Automation.By By { get; }
        public Orc.Automation.Controls.Button CancelButton { get; }
        public Orc.Automation.Controls.ComboBox ColorComboBox { get; }
        public Orc.Automation.Controls.Edit ColorEdit { get; }
        public Orc.Automation.Controls.Edit GEdit { get; }
        public Orc.Automation.Controls.Slider GSlider { get; }
        public Orc.Automation.Controls.Slider HSVSlider { get; }
        public Orc.Controls.Automation.HsvCanvasColorBoardPart HsvCanvas { get; }
        public Orc.Automation.Controls.Edit REdit { get; }
        public Orc.Automation.Controls.Slider RSlider { get; }
        public Orc.Automation.Controls.List RecentColorsListBox { get; }
        public Orc.Automation.Controls.Button SelectButton { get; }
        public Orc.Automation.Controls.Tab Tab { get; }
        public Orc.Automation.Controls.List ThemeColorsListBox { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class ColorBoardModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData ColorProperty;
        public ColorBoardModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public System.Windows.Media.Color Color { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.ColorLegend))]
    public class ColorLegend : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.ColorLegendModel, Orc.Controls.Automation.ColorLegendMap>
    {
        public ColorLegend(System.Windows.Automation.AutomationElement element) { }
        public bool AllowColorEditing { get; set; }
        public bool CanClearSelection { get; }
        public string Filter { get; set; }
        public string FilterWaterMark { get; }
        public bool? IsAllVisible { get; set; }
        public bool IsBottomToolBoxVisible { get; }
        public bool IsSearchBoxVisible { get; }
        public bool IsSettingsBoxVisible { get; }
        public bool IsToolBoxVisible { get; }
        public System.Collections.Generic.List<Orc.Controls.Automation.ColorLegendItemAutomationControl> Items { get; }
        public bool ShowColorPicker { get; set; }
        public bool ShowColorVisibilityControls { get; set; }
        public event System.EventHandler<System.EventArgs> SelectionChanged;
        public TResult InvokeInSettingsScope<TResult>(System.Func<Orc.Controls.Automation.ColorLegendSettingsControl, TResult> action) { }
        public void SetItemCheckState(int index, bool state) { }
    }
    public class ColorLegendAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.ColorLegend>
    {
        public ColorLegendAutomationPeer(Orc.Controls.ColorLegend owner) { }
        [Orc.Automation.AutomationMethod]
        public void SetItemCheckState(int index, bool isChecked) { }
    }
    [Orc.Automation.AutomatedControl(ControlTypeName="ListItem")]
    public class ColorLegendItemAutomationControl : Orc.Automation.Controls.ListItem
    {
        public ColorLegendItemAutomationControl(System.Windows.Automation.AutomationElement element) { }
        public string AdditionalText { get; }
        public string Description { get; }
        public bool IsChecked { get; set; }
    }
    public class ColorLegendMap : Orc.Automation.AutomationBase
    {
        public ColorLegendMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.CheckBox AllVisibleCheckBoxPart { get; }
        public Orc.Automation.Controls.Text FilterWatermarkTextPart { get; }
        public System.Collections.Generic.List<Orc.Controls.Automation.ColorLegendItemAutomationControl> Items { get; }
        public Orc.Automation.Controls.List ListPart { get; }
        public Orc.Automation.Controls.Edit SearchBoxPart { get; }
        public Orc.Automation.Controls.Text SelectedItemCountLabel { get; }
        public Orc.Controls.Automation.DropDownButton SettingsButtonPart { get; }
        public Orc.Automation.Controls.Button UnselectAllButtonPart { get; }
    }
    public class ColorLegendModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData AllowColorEditingProperty;
        public static readonly Catel.Data.IPropertyData EditingColorProperty;
        public static readonly Catel.Data.IPropertyData FilterProperty;
        public static readonly Catel.Data.IPropertyData FilterWatermarkProperty;
        public static readonly Catel.Data.IPropertyData FilteredItemsSourceProperty;
        public static readonly Catel.Data.IPropertyData IsAllVisibleProperty;
        public static readonly Catel.Data.IPropertyData IsColorSelectingProperty;
        public static readonly Catel.Data.IPropertyData ItemsSourceProperty;
        public static readonly Catel.Data.IPropertyData SelectedColorItemsProperty;
        public static readonly Catel.Data.IPropertyData ShowBottomToolBoxProperty;
        public static readonly Catel.Data.IPropertyData ShowColorPickerProperty;
        public static readonly Catel.Data.IPropertyData ShowColorVisibilityControlsProperty;
        public static readonly Catel.Data.IPropertyData ShowSearchBoxProperty;
        public static readonly Catel.Data.IPropertyData ShowSettingsBoxProperty;
        public static readonly Catel.Data.IPropertyData ShowToolBoxProperty;
        public ColorLegendModel(Orc.Automation.AutomationElementAccessor accessor) { }
        [Orc.Automation.ActiveAutomationProperty]
        public bool AllowColorEditing { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Windows.Media.Color EditingColor { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public string Filter { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public string FilterWatermark { get; set; }
        public System.Collections.Generic.IEnumerable<string> FilteredItemsIds { get; }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Collections.Generic.IEnumerable<Orc.Controls.IColorLegendItem> FilteredItemsSource { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool? IsAllVisible { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool IsColorSelecting { get; set; }
        public Orc.Controls.IColorLegendItem this[int index] { get; }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Collections.Generic.IEnumerable<Orc.Controls.IColorLegendItem> ItemsSource { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Collections.Generic.IEnumerable<Orc.Controls.IColorLegendItem> SelectedColorItems { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool ShowBottomToolBox { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool ShowColorPicker { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool ShowColorVisibilityControls { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool ShowSearchBox { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool ShowSettingsBox { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool ShowToolBox { get; set; }
    }
    [Orc.Automation.AutomatedControl(ControlTypeName="Menu")]
    public class ColorLegendSettingsControl : Orc.Automation.Controls.Menu
    {
        public ColorLegendSettingsControl(System.Windows.Automation.AutomationElement element) { }
        public bool AllowColorEditing { get; set; }
        public bool ShowColorPicker { get; set; }
        public bool ShowColorVisibilityControls { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.ColorPicker))]
    public class ColorPicker : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.ColorPickerModel>
    {
        public ColorPicker(System.Windows.Automation.AutomationElement element) { }
        public System.Windows.Media.Color Color { get; set; }
        public event System.EventHandler<System.EventArgs> ColorChanged;
        public Orc.Controls.Automation.ColorBoard OpenColorBoard() { }
    }
    public class ColorPickerAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.ColorPicker>
    {
        public ColorPickerAutomationPeer(Orc.Controls.ColorPicker owner) { }
        [Orc.Automation.AutomationMethod]
        public System.Windows.Media.Color? GetRenderedElementColor() { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class ColorPickerModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData ColorProperty;
        public static readonly Catel.Data.IPropertyData CurrentColorProperty;
        public static readonly Catel.Data.IPropertyData IsDropDownOpenProperty;
        public ColorPickerModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public System.Windows.Media.Color Color { get; set; }
        public System.Windows.Media.Color CurrentColor { get; set; }
        public bool IsDropDownOpen { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.CulturePicker))]
    public class CulturePicker : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.CulturePickerModel, Orc.Automation.CulturePickerMap>
    {
        public CulturePicker(System.Windows.Automation.AutomationElement element) { }
        public System.Collections.Generic.IReadOnlyList<string> Items { get; }
        public string SelectedCulture { get; set; }
    }
    public class CulturePickerModel : Orc.Automation.ControlModel
    {
        public static readonly Catel.Data.IPropertyData SelectedCultureProperty;
        public CulturePickerModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public System.Collections.Generic.List<System.Globalization.CultureInfo> AvailableCultures { get; }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Globalization.CultureInfo SelectedCulture { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.DateTimePicker))]
    public class DateTimePicker : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.DateTimePickerModel, Orc.Controls.Automation.DateTimePickerMap>
    {
        public DateTimePicker(System.Windows.Automation.AutomationElement element) { }
        public System.DateTime? Value { get; set; }
        public void CopyDate() { }
        public Orc.Automation.Controls.Calendar OpenCalendar() { }
        public void OpenSelectTimeDialog() { }
        public void PasteDate() { }
        public void SelectDay(int dayInMonth) { }
        public void SelectHour(int hour) { }
        public void SelectMinute(int minute) { }
        public void SelectMonth(int month) { }
        public void SelectSecond(int second) { }
        public void SetNowValue() { }
        public void SetTodayValue() { }
    }
    public class DateTimePickerAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.DateTimePicker>
    {
        public DateTimePickerAutomationPeer(Orc.Controls.DateTimePicker owner) { }
    }
    public class DateTimePickerMap : Orc.Automation.AutomationBase
    {
        public DateTimePickerMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Controls.Automation.ListTextBox AmPmTextBox { get; }
        public Orc.Automation.Controls.ToggleButton AmPmToggleButton { get; }
        public Orc.Controls.Automation.NumericTextBox DaysTextBox { get; }
        public Orc.Automation.Controls.ToggleButton DaysToggleButton { get; }
        public Orc.Controls.Automation.NumericTextBox HourTextBox { get; }
        public Orc.Automation.Controls.ToggleButton HourToggleButton { get; }
        public Orc.Controls.Automation.NumericTextBox MinuteTextBox { get; }
        public Orc.Automation.Controls.ToggleButton MinuteToggleButton { get; }
        public Orc.Controls.Automation.NumericTextBox MonthTextBox { get; }
        public Orc.Automation.Controls.ToggleButton MonthsToggleButton { get; }
        public Orc.Controls.Automation.DropDownButton OptionDropDownButton { get; }
        public Orc.Controls.Automation.NumericTextBox SecondTextBox { get; }
        public Orc.Automation.Controls.ToggleButton SecondToggleButton { get; }
        public Orc.Controls.Automation.NumericTextBox YearTextBox { get; }
        public Orc.Automation.Controls.ToggleButton YearToggleButton { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class DateTimePickerModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData AllowCopyPasteProperty;
        public static readonly Catel.Data.IPropertyData AllowNullProperty;
        public static readonly Catel.Data.IPropertyData AmPmValueProperty;
        public static readonly Catel.Data.IPropertyData CultureProperty;
        public static readonly Catel.Data.IPropertyData FirstDayOfWeekProperty;
        public static readonly Catel.Data.IPropertyData FormatProperty;
        public static readonly Catel.Data.IPropertyData HideSecondsProperty;
        public static readonly Catel.Data.IPropertyData HideTimeProperty;
        public static readonly Catel.Data.IPropertyData IsControlReadOnlyProperty;
        public static readonly Catel.Data.IPropertyData ShowOptionsButtonProperty;
        public static readonly Catel.Data.IPropertyData TimeValueProperty;
        public static readonly Catel.Data.IPropertyData ValueProperty;
        public DateTimePickerModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public bool AllowCopyPaste { get; set; }
        public bool AllowNull { get; set; }
        public Orc.Controls.Enums.Meridiem AmPmValue { get; set; }
        public System.Globalization.CultureInfo Culture { get; set; }
        public System.DayOfWeek? FirstDayOfWeek { get; set; }
        public string Format { get; set; }
        public bool HideSeconds { get; set; }
        public bool HideTime { get; set; }
        public bool IsAmPmShortFormat { get; }
        [Orc.Automation.ActiveAutomationProperty("IsReadOnly")]
        public bool IsControlReadOnly { get; set; }
        public bool IsHour12Format { get; }
        public bool IsYearShortFormat { get; }
        public bool ShowOptionsButton { get; set; }
        public System.TimeSpan? TimeValue { get; set; }
        public System.DateTime? Value { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.DropDownButton))]
    public class DropDownButton : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.DropDownButtonModel, Orc.Controls.Automation.DropDownButtonMap>
    {
        public DropDownButton(System.Windows.Automation.AutomationElement element) { }
        public bool IsToggled { get; set; }
        public void CloseDropDown() { }
        public void InvokeInDropDownScope(System.Action<Orc.Automation.Controls.Menu> action) { }
        public TResult InvokeInDropDownScope<TResult>(System.Func<Orc.Automation.Controls.Menu, TResult> action) { }
        public Orc.Automation.Controls.Menu OpenDropDown() { }
    }
    public class DropDownButtonAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.DropDownButton>
    {
        public DropDownButtonAutomationPeer(Orc.Controls.DropDownButton owner) { }
        public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { }
    }
    public class DropDownButtonMap : Orc.Automation.AutomationBase
    {
        public DropDownButtonMap(System.Windows.Automation.AutomationElement element) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class DropDownButtonModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData ArrowLocationProperty;
        public static readonly Catel.Data.IPropertyData ArrowMarginProperty;
        public static readonly Catel.Data.IPropertyData HeaderProperty;
        public static readonly Catel.Data.IPropertyData IsArrowVisibleProperty;
        public static readonly Catel.Data.IPropertyData IsCheckedProperty;
        public DropDownButtonModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public Orc.Controls.DropdownArrowLocation ArrowLocation { get; set; }
        public System.Windows.Thickness ArrowMargin { get; set; }
        public object Header { get; set; }
        public bool IsArrowVisible { get; set; }
        public bool IsChecked { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.Expander))]
    public class Expander : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.ExpanderModel>
    {
        public Expander(System.Windows.Automation.AutomationElement element) { }
        public bool IsExpanded { get; set; }
    }
    public class ExpanderAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.Expander>, System.Windows.Automation.Provider.IExpandCollapseProvider
    {
        public ExpanderAutomationPeer(Orc.Controls.Expander owner) { }
        public System.Windows.Automation.ExpandCollapseState ExpandCollapseState { get; }
        public void Collapse() { }
        public void Expand() { }
        public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class ExpanderModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData AutoResizeGridProperty;
        public static readonly Catel.Data.IPropertyData ExpandDirectionProperty;
        public static readonly Catel.Data.IPropertyData ExpandDurationProperty;
        public static readonly Catel.Data.IPropertyData IsExpandedProperty;
        public ExpanderModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public bool AutoResizeGrid { get; set; }
        public Orc.Controls.ExpandDirection ExpandDirection { get; set; }
        public double ExpandDuration { get; set; }
        public bool IsExpanded { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.FilterBox), ControlTypeName="Edit")]
    public class FilterBox : Orc.Automation.Controls.Edit
    {
        public FilterBox(System.Windows.Automation.AutomationElement element) { }
        public Orc.Controls.Automation.FilterBoxModel Current { get; }
        public Orc.Controls.Automation.FilterBoxMap Map { get; }
        public string Watermark { get; }
        public void Clear() { }
        public System.Collections.Generic.List<string> OpenSuggestionList() { }
        public void SelectItemFromSuggestionList(string item) { }
    }
    public class FilterBoxAutomationPeer : Orc.Controls.Automation.TextBoxAutomationPeer<Orc.Controls.FilterBox>
    {
        public FilterBoxAutomationPeer(Orc.Controls.FilterBox owner) { }
        protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { }
    }
    public class FilterBoxMap : Orc.Automation.AutomationBase
    {
        public FilterBoxMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Button ClearButton { get; }
        public Orc.Automation.Controls.Edit Edit { get; }
        public Orc.Automation.Controls.Text WatermarkText { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class FilterBoxModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData AllowAutoCompletionProperty;
        public static readonly Catel.Data.IPropertyData FilterSourceProperty;
        public static readonly Catel.Data.IPropertyData PropertyNameProperty;
        public static readonly Catel.Data.IPropertyData TextProperty;
        public static readonly Catel.Data.IPropertyData WatermarkProperty;
        public FilterBoxModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public bool AllowAutoCompletion { get; set; }
        public System.Collections.IEnumerable FilterSource { get; set; }
        public string PropertyName { get; set; }
        public string Text { get; set; }
        public string Watermark { get; set; }
    }
    [Orc.Automation.AutomatedControl(ControlTypeName="Window")]
    public class FindReplaceView : Orc.Automation.Controls.Window
    {
        public FindReplaceView(System.Windows.Automation.AutomationElement element) { }
        public bool IsCaseSensitive { get; set; }
        public bool IsRegex { get; set; }
        public bool IsWholeWord { get; set; }
        public bool IsWildcards { get; set; }
        public bool SearchUp { get; set; }
        public void Find(string text) { }
        public void Replace(string text, string replacementText) { }
        public void ReplaceAll(string text, string replacementText) { }
    }
    public class FindReplaceViewMap : Orc.Automation.AutomationBase
    {
        public FindReplaceViewMap(System.Windows.Automation.AutomationElement element) { }
        public override Orc.Automation.By By { get; }
        public Orc.Automation.Controls.CheckBox CaseSensitiveCheckBox { get; }
        public Orc.Automation.Controls.Edit FindEdit { get; }
        public Orc.Automation.Controls.Button FindNextButton { get; }
        public Orc.Automation.Controls.Edit FindReplaceEdit { get; }
        public Orc.Automation.Controls.Button FindReplaceNextButton { get; }
        public Orc.Automation.Controls.CheckBox RegexCheckBox { get; }
        public Orc.Automation.Controls.Button ReplaceAllButton { get; }
        public Orc.Automation.Controls.Button ReplaceButton { get; }
        public Orc.Automation.Controls.Edit ReplaceEdit { get; }
        public Orc.Automation.Controls.CheckBox SearchUpCheckBox { get; }
        public Orc.Automation.Controls.Tab Tab { get; }
        public Orc.Automation.Controls.CheckBox WholeWordCheckBox { get; }
        public Orc.Automation.Controls.CheckBox WildcardsCheckBox { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class FindReplaceViewModel : Orc.Automation.ControlModel
    {
        public FindReplaceViewModel(Orc.Automation.AutomationElementAccessor accessor) { }
    }
    public class FluidProgressBar : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.FluidProgressBarModel>
    {
        public FluidProgressBar(System.Windows.Automation.AutomationElement element) { }
    }
    public class FluidProgressBarAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.FluidProgressBar>
    {
        public FluidProgressBarAutomationPeer(Orc.Controls.FluidProgressBar owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class FluidProgressBarModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData DelayProperty;
        public static readonly Catel.Data.IPropertyData DotHeightProperty;
        public static readonly Catel.Data.IPropertyData DotRadiusXProperty;
        public static readonly Catel.Data.IPropertyData DotRadiusYProperty;
        public static readonly Catel.Data.IPropertyData DotWidthProperty;
        public static readonly Catel.Data.IPropertyData DurationAProperty;
        public static readonly Catel.Data.IPropertyData DurationBProperty;
        public static readonly Catel.Data.IPropertyData DurationCProperty;
        public static readonly Catel.Data.IPropertyData ForegroundProperty;
        public static readonly Catel.Data.IPropertyData KeyFrameAProperty;
        public static readonly Catel.Data.IPropertyData KeyFrameBProperty;
        public static readonly Catel.Data.IPropertyData OscillateProperty;
        public static readonly Catel.Data.IPropertyData ReverseDurationProperty;
        public static readonly Catel.Data.IPropertyData TotalDurationProperty;
        public FluidProgressBarModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public System.Windows.Duration Delay { get; set; }
        public double DotHeight { get; set; }
        public double DotRadiusX { get; set; }
        public double DotRadiusY { get; set; }
        public double DotWidth { get; set; }
        public System.Windows.Duration DurationA { get; set; }
        public System.Windows.Duration DurationB { get; set; }
        public System.Windows.Duration DurationC { get; set; }
        public System.Windows.Media.SolidColorBrush Foreground { get; set; }
        public double KeyFrameA { get; set; }
        public double KeyFrameB { get; set; }
        public bool Oscillate { get; set; }
        public System.Windows.Duration ReverseDuration { get; set; }
        public System.Windows.Duration TotalDuration { get; set; }
    }
    public class FontImage : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.FontImageModel>
    {
        public FontImage(System.Windows.Automation.AutomationElement element) { }
    }
    public class FontImageAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.FontImage>
    {
        public FontImageAutomationPeer(Orc.Controls.FontImage owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class FontImageModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData FontFamilyProperty;
        public static readonly Catel.Data.IPropertyData ForegroundProperty;
        public static readonly Catel.Data.IPropertyData ItemNameProperty;
        public FontImageModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public string FontFamily { get; set; }
        public System.Windows.Media.SolidColorBrush Foreground { get; set; }
        public string ItemName { get; set; }
    }
    public class FrameCounter : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.FrameRateCounterModel>
    {
        public FrameCounter(System.Windows.Automation.AutomationElement element) { }
    }
    public class FrameCounterAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.FrameCounter>
    {
        public FrameCounterAutomationPeer(Orc.Controls.FrameCounter owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class FrameCounterModel : Orc.Automation.AutomationControlModel
    {
        public static readonly Catel.Data.IPropertyData PrefixProperty;
        public static readonly Catel.Data.IPropertyData ResetCountProperty;
        public FrameCounterModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public string Prefix { get; set; }
        public int ResetCount { get; set; }
    }
    public class FrameRateCounter : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.FrameRateCounterModel>
    {
        public FrameRateCounter(System.Windows.Automation.AutomationElement element) { }
    }
    public class FrameRateCounterAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.FrameRateCounter>
    {
        public FrameRateCounterAutomationPeer(Orc.Controls.FrameRateCounter owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class FrameRateCounterModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData PrefixProperty;
        public FrameRateCounterModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public string Prefix { get; set; }
    }
    public class HeaderBar : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.HeaderBarModel>
    {
        public HeaderBar(System.Windows.Automation.AutomationElement element) { }
    }
    public class HeaderBarAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.HeaderBar>
    {
        public HeaderBarAutomationPeer(Orc.Controls.HeaderBar owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class HeaderBarModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData HeaderProperty;
        public HeaderBarModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public string Header { get; set; }
    }
    public class HsvCanvasColorBoardPart : Orc.Automation.AutomationControl
    {
        public HsvCanvasColorBoardPart(Orc.Controls.Automation.ColorBoard colorBoard) { }
        public override System.Windows.Rect BoundingRectangle { get; }
        public System.Windows.Point GetSV() { }
        public void SetColor(System.Windows.Media.Color color) { }
    }
    public class LinkLabel : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.LinkLabelModel, Orc.Controls.Automation.LinkLabelMap>
    {
        public LinkLabel(System.Windows.Automation.AutomationElement element) { }
        public string Content { get; }
        public event System.EventHandler<System.EventArgs> Click;
        public event System.EventHandler<System.EventArgs> RequestNavigate;
        public void Invoke() { }
    }
    public class LinkLabelAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.LinkLabel>
    {
        public LinkLabelAutomationPeer(Orc.Controls.LinkLabel owner) { }
    }
    public class LinkLabelMap : Orc.Automation.AutomationBase
    {
        public LinkLabelMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Hyperlink Hyperlink { get; }
        public Orc.Automation.Controls.Text Text { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class LinkLabelModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData ClickBehaviorProperty;
        public static readonly Catel.Data.IPropertyData CommandParameterProperty;
        public static readonly Catel.Data.IPropertyData ContentProperty;
        public static readonly Catel.Data.IPropertyData HoverForegroundProperty;
        public static readonly Catel.Data.IPropertyData LinkLabelBehaviorProperty;
        public static readonly Catel.Data.IPropertyData UrlProperty;
        public LinkLabelModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public Orc.Controls.LinkLabelClickBehavior ClickBehavior { get; set; }
        public object CommandParameter { get; set; }
        public object Content { get; set; }
        public bool HasUrl { get; }
        public System.Windows.Media.SolidColorBrush HoverForeground { get; set; }
        public Orc.Controls.LinkLabelBehavior LinkLabelBehavior { get; set; }
        public System.Uri Url { get; set; }
    }
    [Orc.Automation.AutomatedControl(ControlTypeName="Edit")]
    public class ListTextBox : Orc.Automation.Controls.Edit
    {
        public ListTextBox(System.Windows.Automation.AutomationElement element) { }
        public Orc.Controls.Automation.ListTextBoxModel Current { get; }
    }
    public class ListTextBoxAutomationPeer : Orc.Controls.Automation.TextBoxAutomationPeer<Orc.Controls.ListTextBox>
    {
        public ListTextBoxAutomationPeer(Orc.Controls.ListTextBox owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class ListTextBoxModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData ListOfValuesProperty;
        public static readonly Catel.Data.IPropertyData TextProperty;
        public static readonly Catel.Data.IPropertyData ValueProperty;
        public ListTextBoxModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public System.Collections.Generic.List<string> ListOfValues { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
    }
    public class LogMessageCategoryToggleButton : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.LogMessageCategoryToggleButtonModel, Orc.Controls.Automation.LogMessageCategoryToggleButtonMap>
    {
        public LogMessageCategoryToggleButton(System.Windows.Automation.AutomationElement element) { }
        public string Category { get; }
        public int EntryCount { get; }
        public bool IsToggled { get; set; }
    }
    public class LogMessageCategoryToggleButtonMap : Orc.Automation.AutomationBase
    {
        public LogMessageCategoryToggleButtonMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Text CategoryText { get; }
        public Orc.Automation.Controls.Text EntryCountText { get; }
        public Orc.Automation.Controls.ToggleButton Toggle { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class LogMessageCategoryToggleButtonModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData CategoryProperty;
        public static readonly Catel.Data.IPropertyData EntryCountProperty;
        public static readonly Catel.Data.IPropertyData IsCheckedProperty;
        public LogMessageCategoryToggleButtonModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public string Category { get; set; }
        public int EntryCount { get; set; }
        public bool IsChecked { get; set; }
    }
    public class LogMessageCategoryToggleButtonModelPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.LogMessageCategoryToggleButton>
    {
        public LogMessageCategoryToggleButtonModelPeer(Orc.Controls.LogMessageCategoryToggleButton owner) { }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.NumericTextBox), ControlTypeName="Edit")]
    public class NumericTextBox : Orc.Automation.Controls.Edit
    {
        public NumericTextBox(System.Windows.Automation.AutomationElement element) { }
        public Orc.Controls.Automation.NumericTextBoxModel Current { get; }
    }
    public class NumericTextBoxAutomationPeer : Orc.Controls.Automation.TextBoxAutomationPeer<Orc.Controls.NumericTextBox>
    {
        public NumericTextBoxAutomationPeer(Orc.Controls.NumericTextBox owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class NumericTextBoxModel : Orc.Automation.AutomationControlModel
    {
        public static readonly Catel.Data.IPropertyData CultureInfoProperty;
        public static readonly Catel.Data.IPropertyData FormatProperty;
        public static readonly Catel.Data.IPropertyData IsChangeValueByUpDownKeyEnabledProperty;
        public static readonly Catel.Data.IPropertyData IsDecimalAllowedProperty;
        public static readonly Catel.Data.IPropertyData IsNegativeAllowedProperty;
        public static readonly Catel.Data.IPropertyData IsNullValueAllowedProperty;
        public static readonly Catel.Data.IPropertyData MaxValueProperty;
        public static readonly Catel.Data.IPropertyData MinValueProperty;
        public static readonly Catel.Data.IPropertyData NullStringProperty;
        public static readonly Catel.Data.IPropertyData TextProperty;
        public NumericTextBoxModel(Orc.Automation.AutomationElementAccessor accessor) { }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Globalization.CultureInfo CultureInfo { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public string Format { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool IsChangeValueByUpDownKeyEnabled { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool IsDecimalAllowed { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool IsNegativeAllowed { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool IsNullValueAllowed { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public double MaxValue { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public double MinValue { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public string NullString { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public string Text { get; set; }
        public double? Value { get; set; }
    }
    public class NumericUpDown : Orc.Automation.Controls.FrameworkElement
    {
        public NumericUpDown(System.Windows.Automation.AutomationElement element) { }
        public int DecimalPlaces { get; set; }
        public bool IsAutoSelectionActive { get; set; }
        public bool IsDecimalPointDynamic { get; set; }
        public bool IsThousandSeparatorVisible { get; set; }
        public double MajorDelta { get; set; }
        public int MaxDecimalPlaces { get; set; }
        public double MaxValue { get; set; }
        public int MinDecimalPlaces { get; set; }
        public double MinValue { get; set; }
        public double MinorDelta { get; set; }
        public Orc.Controls.Number Value { get; set; }
        public Orc.Controls.Automation.NumericUpDownView View { get; }
    }
    public class NumericUpDownMap : Orc.Automation.AutomationBase
    {
        public NumericUpDownMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Border Chrome { get; }
        public Orc.Automation.Controls.Edit Edit { get; }
        public Orc.Controls.Automation.SpinButton SpinButton { get; }
    }
    public class NumericUpDownView : Orc.Automation.AutomationBase
    {
        public NumericUpDownView(System.Windows.Automation.AutomationElement element) { }
        public string Value { get; set; }
        public void DecreaseNumber() { }
        public void IncreaseNumber() { }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.OpenFilePicker))]
    public class OpenFilePicker : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.OpenFilePickerModel, Orc.Controls.Automation.OpenFilePickerMap>
    {
        public OpenFilePicker(System.Windows.Automation.AutomationElement element) { }
        public System.Collections.Generic.List<string> Filters { get; }
        public string SelectedFileDisplayPath { get; }
        public void Clear() { }
        public void OpenContainingDirectory() { }
        public Orc.Automation.Controls.OpenFileDialog OpenFileDialog() { }
        public void SelectFile(string filePath) { }
    }
    public class OpenFilePickerAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.OpenFilePicker>
    {
        public OpenFilePickerAutomationPeer(Orc.Controls.OpenFilePicker owner) { }
    }
    public class OpenFilePickerMap : Orc.Automation.AutomationBase
    {
        public static string ClearButtonId;
        public static string OpenDirectoryButtonId;
        public static string OpenFileButtonId;
        public static string SelectedFileTextBoxId;
        public OpenFilePickerMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Button ClearButton { get; }
        public Orc.Automation.Controls.Button OpenDirectoryButton { get; }
        public Orc.Automation.Controls.Button OpenFileButton { get; }
        public Orc.Automation.Controls.Edit SelectedFileTextBox { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class OpenFilePickerModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData BaseDirectoryProperty;
        public static readonly Catel.Data.IPropertyData FilterProperty;
        public static readonly Catel.Data.IPropertyData LabelTextProperty;
        public static readonly Catel.Data.IPropertyData LabelWidthProperty;
        public static readonly Catel.Data.IPropertyData SelectedFileProperty;
        public OpenFilePickerModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public string BaseDirectory { get; set; }
        public string Filter { get; set; }
        public string LabelText { get; set; }
        public double LabelWidth { get; set; }
        public string SelectedFile { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.PinnableToolTip))]
    public class PinnableToolTip : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.PinnableToolTipModel, Orc.Controls.Automation.PinnableToolTipMap>
    {
        public PinnableToolTip(System.Windows.Automation.AutomationElement element) { }
        public bool IsPinned { get; set; }
        public System.Windows.Point Position { get; set; }
        public void Close() { }
    }
    public class PinnableToolTipAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.PinnableToolTip>
    {
        public PinnableToolTipAutomationPeer(Orc.Controls.PinnableToolTip owner) { }
        [Orc.Automation.AutomationMethod]
        public object GetOwner() { }
    }
    public class PinnableToolTipMap : Orc.Automation.AutomationBase
    {
        public PinnableToolTipMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Button CloseButton { get; }
        public Orc.Automation.Controls.Border GripBorder { get; }
        public Orc.Automation.Controls.ToggleButton PinButton { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class PinnableToolTipModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData AllowCloseByUserProperty;
        public static readonly Catel.Data.IPropertyData GripColorProperty;
        public static readonly Catel.Data.IPropertyData HorizontalOffsetProperty;
        public static readonly Catel.Data.IPropertyData IsPinnedProperty;
        public static readonly Catel.Data.IPropertyData ResizeModeProperty;
        public static readonly Catel.Data.IPropertyData VerticalOffsetProperty;
        public PinnableToolTipModel(Orc.Automation.AutomationElementAccessor accessor) { }
        [Orc.Automation.ActiveAutomationProperty]
        public bool AllowCloseByUser { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Windows.Media.Color GripColor { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public double HorizontalOffset { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public bool IsPinned { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Windows.Input.ICommand OpenLinkCommand { get; set; }
        public object Owner { get; }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Windows.ResizeMode ResizeMode { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public double VerticalOffset { get; set; }
    }
    [Orc.Automation.ActiveAutomationModel(DefaultOwnerType=typeof(Orc.Controls.PinnableToolTipService))]
    public class PinnableToolTipServiceModel : Orc.Automation.AutomationControlModel
    {
        public static readonly Catel.Data.IPropertyData InitialShowDelayProperty;
        public static readonly Catel.Data.IPropertyData IsToolTipOwnerProperty;
        public static readonly Catel.Data.IPropertyData PlacementProperty;
        public static readonly Catel.Data.IPropertyData ShowDurationProperty;
        public PinnableToolTipServiceModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public int InitialShowDelay { get; set; }
        public bool IsToolTipOwner { get; set; }
        public System.Windows.Controls.Primitives.PlacementMode Placement { get; set; }
        public int ShowDuration { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.PredefinedColorItem))]
    public class PredefinedColorItem : Orc.Automation.AutomationControl
    {
        public PredefinedColorItem(System.Windows.Automation.AutomationElement element) { }
        public System.Windows.Media.Color Color { get; }
        public bool IsSelected { get; set; }
        public string Text { get; }
    }
    public class RangeSlider : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.RangeSliderModel, Orc.Controls.Automation.RangeSliderMap>
    {
        public RangeSlider(System.Windows.Automation.AutomationElement element) { }
        public double LowerValue { get; set; }
        public double Maximum { get; }
        public double Minimum { get; }
        public double UpperValue { get; set; }
    }
    public class RangeSliderAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.RangeSlider>
    {
        public RangeSliderAutomationPeer(Orc.Controls.RangeSlider owner) { }
    }
    public class RangeSliderMap : Orc.Automation.AutomationBase
    {
        public RangeSliderMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Slider LowerSlider { get; }
        public Orc.Automation.Controls.Slider UpperSlider { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class RangeSliderModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData HighlightSelectedRangeProperty;
        public static readonly Catel.Data.IPropertyData LowerValueProperty;
        public static readonly Catel.Data.IPropertyData MaximumProperty;
        public static readonly Catel.Data.IPropertyData MinimumProperty;
        public static readonly Catel.Data.IPropertyData OrientationProperty;
        public static readonly Catel.Data.IPropertyData UpperValueProperty;
        public RangeSliderModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public bool HighlightSelectedRange { get; set; }
        public double LowerValue { get; set; }
        public double Maximum { get; set; }
        public double Minimum { get; set; }
        public System.Windows.Controls.Orientation Orientation { get; set; }
        public double UpperValue { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.SaveFilePicker))]
    public class SaveFilePicker : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.SaveFilePickerModel, Orc.Controls.Automation.SaveFilePickerMap>
    {
        public SaveFilePicker(System.Windows.Automation.AutomationElement element) { }
    }
    public class SaveFilePickerAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.SaveFilePicker>
    {
        public SaveFilePickerAutomationPeer(Orc.Controls.SaveFilePicker owner) { }
    }
    public class SaveFilePickerMap : Orc.Automation.AutomationBase
    {
        public SaveFilePickerMap(System.Windows.Automation.AutomationElement element) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class SaveFilePickerModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData FilterProperty;
        public static readonly Catel.Data.IPropertyData LabelTextProperty;
        public static readonly Catel.Data.IPropertyData LabelWidthProperty;
        public static readonly Catel.Data.IPropertyData SelectedFileProperty;
        public SaveFilePickerModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public string Filter { get; set; }
        public string LabelText { get; set; }
        public double LabelWidth { get; set; }
        public string SelectedFile { get; set; }
    }
    public class SetNumericTextBoxValueRun : Orc.Automation.NamedAutomationMethodRun
    {
        public SetNumericTextBoxValueRun() { }
        public override bool TryInvoke(System.Windows.FrameworkElement owner, Orc.Automation.AutomationMethod method, out Orc.Automation.AutomationValue result) { }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.SpinButton))]
    public class SpinButton : Orc.Automation.Controls.FrameworkElement
    {
        public SpinButton(System.Windows.Automation.AutomationElement element) { }
        public event System.EventHandler<System.EventArgs> Canceled;
        public event System.EventHandler<System.EventArgs> Decreased;
        public event System.EventHandler<System.EventArgs> Increased;
        public void Decrease() { }
        public void Increase() { }
    }
    public class SpinButtonAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.SpinButton>
    {
        public SpinButtonAutomationPeer(Orc.Controls.SpinButton owner) { }
    }
    public class SpinButtonMap : Orc.Automation.AutomationBase
    {
        public SpinButtonMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Button DecreaseButton { get; }
        public Orc.Automation.Controls.Button IncreaseButton { get; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.StaggeredPanel))]
    public class StaggeredPanel : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.StaggeredPanelModel, Orc.Controls.Automation.StaggeredPanelMap>
    {
        public StaggeredPanel(System.Windows.Automation.AutomationElement element) { }
    }
    public class StaggeredPanelAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.StaggeredPanel>
    {
        public StaggeredPanelAutomationPeer(Orc.Controls.StaggeredPanel owner) { }
    }
    public class StaggeredPanelMap : Orc.Automation.AutomationBase
    {
        public StaggeredPanelMap(System.Windows.Automation.AutomationElement element) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class StaggeredPanelModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData ColumnSpacingProperty;
        public static readonly Catel.Data.IPropertyData DesiredColumnWidthProperty;
        public static readonly Catel.Data.IPropertyData PaddingProperty;
        public static readonly Catel.Data.IPropertyData RowSpacingProperty;
        public StaggeredPanelModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public double ColumnSpacing { get; set; }
        public double DesiredColumnWidth { get; set; }
        public System.Windows.Thickness Padding { get; set; }
        public double RowSpacing { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.StepBar))]
    public class StepBar : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.StepBarModel, Orc.Controls.Automation.StepBarMap>
    {
        public StepBar(System.Windows.Automation.AutomationElement element) { }
        public System.Collections.Generic.IReadOnlyList<Orc.Controls.Automation.StepBarItem> Items { get; }
        public Orc.Controls.Automation.StepBarItem SelectedItem { get; }
    }
    public class StepBarAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.StepBar>
    {
        public StepBarAutomationPeer(Orc.Controls.StepBar owner) { }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.StepBarItem))]
    public class StepBarItem : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.StepBarItemModel, Orc.Controls.Automation.StepBarItemMap>
    {
        public StepBarItem(System.Windows.Automation.AutomationElement element) { }
        public string Number { get; }
        public string Title { get; }
        public void Invoke() { }
    }
    public class StepBarItemAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.StepBarItem>
    {
        public StepBarItemAutomationPeer(Orc.Controls.StepBarItem owner) { }
    }
    public class StepBarItemMap : Orc.Automation.AutomationBase
    {
        public StepBarItemMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Text EllipseTextBlock { get; }
        public Orc.Automation.Controls.Button ExecuteButton { get; }
        public Orc.Automation.Controls.Text TitleTextBlock { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class StepBarItemModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData OrientationProperty;
        public StepBarItemModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public System.Windows.Controls.Orientation Orientation { get; set; }
    }
    public class StepBarMap : Orc.Automation.AutomationBase
    {
        public StepBarMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.List ItemList { get; }
    }
    public class StepBarModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData ItemsProperty;
        public static readonly Catel.Data.IPropertyData OrientationProperty;
        public StepBarModel(Orc.Automation.AutomationElementAccessor accessor) { }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Collections.Generic.List<Orc.Controls.IStepBarItem> Items { get; set; }
        [Orc.Automation.ActiveAutomationProperty]
        public System.Windows.Controls.Orientation Orientation { get; set; }
        public Orc.Controls.IStepBarItem SelectedItem { get; set; }
    }
    public class StepBarSelectItemByTitleNumberDescriptionMethodRun : Orc.Automation.NamedAutomationMethodRun
    {
        public StepBarSelectItemByTitleNumberDescriptionMethodRun() { }
        public override bool TryInvoke(System.Windows.FrameworkElement owner, Orc.Automation.AutomationMethod method, out Orc.Automation.AutomationValue result) { }
    }
    public class TextBoxAutomationPeer<TControl> : Orc.Automation.AutomationControlPeerBase<TControl>
        where TControl : System.Windows.Controls.TextBox
    {
        public TextBoxAutomationPeer(TControl owner) { }
        protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { }
        public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { }
        protected override string GetValueFromPattern() { }
        protected override void SetValuePatternInvoke(string value) { }
    }
    [Orc.Automation.AutomatedControl(ControlTypeName="Window")]
    public class TextInputWindow : Orc.Automation.Controls.Window
    {
        public TextInputWindow(System.Windows.Automation.AutomationElement element) { }
        public string Text { get; set; }
        public void Accept() { }
        public void Cancel() { }
    }
    public class TextInputWindowMap : Orc.Automation.AutomationBase
    {
        public TextInputWindowMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Button CancelButton { get; }
        public Orc.Automation.Controls.Button OkButton { get; }
        public Orc.Automation.Controls.Edit TextEdit { get; }
    }
    public class TimePicker : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.TimePickerModel>
    {
        public TimePicker(System.Windows.Automation.AutomationElement element) { }
    }
    public class TimePickerAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.TimePicker>
    {
        public TimePickerAutomationPeer(Orc.Controls.TimePicker owner) { }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class TimePickerModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData AmPmValueProperty;
        public static readonly Catel.Data.IPropertyData ClockBorderThicknessProperty;
        public static readonly Catel.Data.IPropertyData HourBrushProperty;
        public static readonly Catel.Data.IPropertyData HourThicknessProperty;
        public static readonly Catel.Data.IPropertyData HourTickBrushProperty;
        public static readonly Catel.Data.IPropertyData HourTickThicknessProperty;
        public static readonly Catel.Data.IPropertyData Is24HourFormatProperty;
        public static readonly Catel.Data.IPropertyData MinuteBrushProperty;
        public static readonly Catel.Data.IPropertyData MinuteThicknessProperty;
        public static readonly Catel.Data.IPropertyData MinuteTickBrushProperty;
        public static readonly Catel.Data.IPropertyData MinuteTickThicknessProperty;
        public static readonly Catel.Data.IPropertyData ShowNumbersProperty;
        public static readonly Catel.Data.IPropertyData TimeValueProperty;
        public TimePickerModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public Orc.Controls.Enums.Meridiem AmPmValue { get; set; }
        public double ClockBorderThickness { get; set; }
        public System.Windows.Media.Brush HourBrush { get; set; }
        public double HourThickness { get; set; }
        public System.Windows.Media.Brush HourTickBrush { get; set; }
        public double HourTickThickness { get; set; }
        public bool Is24HourFormat { get; set; }
        public System.Windows.Media.Brush MinuteBrush { get; set; }
        public double MinuteThickness { get; set; }
        public System.Windows.Media.Brush MinuteTickBrush { get; set; }
        public double MinuteTickThickness { get; set; }
        public bool ShowNumbers { get; set; }
        public System.TimeSpan TimeValue { get; set; }
    }
    public class TimeSpanPicker : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.TimeSpanPickerModel, Orc.Controls.Automation.TimeSpanPickerMap>
    {
        public TimeSpanPicker(System.Windows.Automation.AutomationElement element) { }
        public double? EditorValue { get; }
        public double? TotalDays { get; set; }
        public double? TotalHours { get; set; }
        public double? TotalMinutes { get; set; }
        public double? TotalSeconds { get; set; }
        public System.TimeSpan? Value { get; set; }
    }
    public class TimeSpanPickerAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.TimeSpanPicker>
    {
        public TimeSpanPickerAutomationPeer(Orc.Controls.TimeSpanPicker owner) { }
    }
    public class TimeSpanPickerMap : Orc.Automation.AutomationBase
    {
        public TimeSpanPickerMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Text DaysAbbreviationTextBlock { get; }
        public Orc.Automation.Controls.Text DaysHoursSeparatorTextBlock { get; }
        public Orc.Controls.Automation.NumericTextBox DaysNumericTextBox { get; }
        public Orc.Automation.Controls.Text EditedUnitTextBlock { get; }
        public Orc.Controls.Automation.NumericTextBox EditorNumericTextBox { get; }
        public Orc.Automation.Controls.Text HoursAbbreviationTextBlock { get; }
        public Orc.Automation.Controls.Text HoursMinutesSeparatorTextBlock { get; }
        public Orc.Controls.Automation.NumericTextBox HoursNumericTextBox { get; }
        public Orc.Automation.Controls.Text MinutesAbbreviationTextBlock { get; }
        public Orc.Controls.Automation.NumericTextBox MinutesNumericTextBox { get; }
        public Orc.Automation.Controls.Text MinutesSecondsSeparatorTextBlock { get; }
        public Orc.Automation.Controls.Text SecondsAbbreviationTextBlock { get; }
        public Orc.Controls.Automation.NumericTextBox SecondsNumericTextBox { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class TimeSpanPickerModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData CanEditProperty;
        public static readonly Catel.Data.IPropertyData ValueProperty;
        public TimeSpanPickerModel(Orc.Automation.AutomationElementAccessor accessor) { }
        [Orc.Automation.ActiveAutomationProperty("IsReadOnly")]
        public bool CanEdit { get; set; }
        public System.TimeSpan? Value { get; set; }
    }
    public class ValidationContextResultTreeItem : Orc.Controls.Automation.ValidationContextTreeItemBase
    {
        public ValidationContextResultTreeItem(System.Windows.Automation.AutomationElement element) { }
        public string Message { get; }
    }
    public class ValidationContextTagTreeItem : Orc.Controls.Automation.ValidationContextTreeItemBase
    {
        public ValidationContextTagTreeItem(System.Windows.Automation.AutomationElement element) { }
        public string Tag { get; }
        public System.Collections.Generic.IReadOnlyList<Orc.Controls.Automation.ValidationContextTypeTreeItem> TypeNodes { get; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.ValidationContextTree))]
    public class ValidationContextTree : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.ValidationContextTreeModel, Orc.Controls.Automation.ValidationContextTreeMap>, System.Collections.Generic.IEnumerable<Orc.Controls.Automation.ValidationContextTagTreeItem>, System.Collections.IEnumerable
    {
        public ValidationContextTree(System.Windows.Automation.AutomationElement element) { }
        public System.Collections.Generic.IReadOnlyList<Orc.Controls.Automation.ValidationContextTagTreeItem> TagNodes { get; }
        public System.Collections.Generic.IEnumerator<Orc.Controls.Automation.ValidationContextTagTreeItem> GetEnumerator() { }
        public System.Collections.Generic.IReadOnlyList<string> GetValidationItems(string tag, Catel.Data.ValidationResultType type) { }
    }
    public class ValidationContextTreeAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.ValidationContextTree>
    {
        public ValidationContextTreeAutomationPeer(Orc.Controls.ValidationContextTree owner) { }
    }
    public abstract class ValidationContextTreeItemBase : Orc.Automation.Controls.FrameworkElement
    {
        protected readonly Orc.Automation.Controls.TreeItem _treeItem;
        protected ValidationContextTreeItemBase(System.Windows.Automation.AutomationElement element) { }
        public bool IsExpanded { get; set; }
    }
    public class ValidationContextTreeMap : Orc.Automation.AutomationBase
    {
        public ValidationContextTreeMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Tree InnerTree { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class ValidationContextTreeModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData FilterProperty;
        public static readonly Catel.Data.IPropertyData IsExpandedByDefaultProperty;
        public static readonly Catel.Data.IPropertyData NodesProperty;
        public static readonly Catel.Data.IPropertyData ShowErrorsProperty;
        public static readonly Catel.Data.IPropertyData ShowWarningsProperty;
        public static readonly Catel.Data.IPropertyData ValidationContextProperty;
        public ValidationContextTreeModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public string Filter { get; set; }
        public bool IsExpandedByDefault { get; set; }
        public System.Collections.Generic.IEnumerable<Orc.Controls.IValidationContextTreeNode> Nodes { get; set; }
        public bool ShowErrors { get; set; }
        public bool ShowWarnings { get; set; }
        public Catel.Data.IValidationContext ValidationContext { get; set; }
    }
    public class ValidationContextTypeTreeItem : Orc.Controls.Automation.ValidationContextTreeItemBase
    {
        public ValidationContextTypeTreeItem(System.Windows.Automation.AutomationElement element) { }
        public System.Collections.Generic.IReadOnlyList<Orc.Controls.Automation.ValidationContextResultTreeItem> ResultNodes { get; }
        public Catel.Data.ValidationResultType Type { get; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.Automation.ValidationContextView))]
    public class ValidationContextView : Orc.Automation.Controls.FrameworkElement<Orc.Controls.Automation.ValidationContextViewModel, Orc.Controls.Automation.ValidationContextViewMap>, System.Collections.Generic.IEnumerable<Orc.Controls.Automation.ValidationContextTagTreeItem>, System.Collections.IEnumerable
    {
        public ValidationContextView(System.Windows.Automation.AutomationElement element) { }
        public string Filter { get; set; }
        public bool IsErrorsVisible { get; set; }
        public bool IsExpanded { get; set; }
        public bool IsFilterVisible { get; }
        public bool IsWarningsVisible { get; set; }
        public System.Collections.Generic.IReadOnlyList<Orc.Controls.Automation.ValidationContextTagTreeItem> TabItems { get; }
        public System.Collections.Generic.IEnumerator<Orc.Controls.Automation.ValidationContextTagTreeItem> GetEnumerator() { }
        public System.Collections.Generic.IReadOnlyList<string> GetValidationItems(string tag, Catel.Data.ValidationResultType type) { }
    }
    public class ValidationContextViewAutomationPeer : Orc.Automation.AutomationControlPeerBase<Orc.Controls.ValidationContextView>
    {
        public ValidationContextViewAutomationPeer(Orc.Controls.ValidationContextView owner) { }
    }
    public class ValidationContextViewMap : Orc.Automation.AutomationBase
    {
        public ValidationContextViewMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Button CollapseAllButton { get; }
        public Orc.Automation.Controls.Button CopyButton { get; }
        public Orc.Automation.Controls.Button ExpandAllButton { get; }
        public Orc.Controls.Automation.FilterBox FilterBox { get; }
        public Orc.Automation.Controls.Button OpenButton { get; }
        public Orc.Controls.Automation.LogMessageCategoryToggleButton ShowErrorsButton { get; }
        public Orc.Controls.Automation.LogMessageCategoryToggleButton ShowWarningButton { get; }
        public Orc.Controls.Automation.ValidationContextTree Tree { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class ValidationContextViewModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData IsExpandedAllOnStartupProperty;
        public static readonly Catel.Data.IPropertyData ShowButtonsProperty;
        public static readonly Catel.Data.IPropertyData ShowFilterBoxProperty;
        public static readonly Catel.Data.IPropertyData ValidationContextProperty;
        public ValidationContextViewModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public bool IsExpandedAllOnStartup { get; set; }
        public bool ShowButtons { get; set; }
        public bool ShowFilterBox { get; set; }
        public Catel.Data.ValidationContext ValidationContext { get; set; }
    }
    [Orc.Automation.AutomatedControl(Class=typeof(Orc.Controls.WatermarkTextBox), ControlTypeName="Edit")]
    public class WatermarkTextBox : Orc.Automation.Controls.Edit
    {
        public WatermarkTextBox(System.Windows.Automation.AutomationElement element) { }
        public Orc.Controls.Automation.WatermarkTextBoxModel Current { get; }
        public Orc.Controls.Automation.WatermarkTextBoxMap Map { get; }
        public string Watermark { get; }
    }
    public class WatermarkTextBoxAutomationPeer : Orc.Controls.Automation.TextBoxAutomationPeer<Orc.Controls.WatermarkTextBox>
    {
        public WatermarkTextBoxAutomationPeer(Orc.Controls.WatermarkTextBox owner) { }
        protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { }
    }
    public class WatermarkTextBoxMap : Orc.Automation.AutomationBase
    {
        public WatermarkTextBoxMap(System.Windows.Automation.AutomationElement element) { }
        public Orc.Automation.Controls.Edit Edit { get; }
        public Orc.Automation.Controls.Text WatermarkText { get; }
    }
    [Orc.Automation.ActiveAutomationModel]
    public class WatermarkTextBoxModel : Orc.Automation.FrameworkElementModel
    {
        public static readonly Catel.Data.IPropertyData SelectAllOnGotFocusProperty;
        public static readonly Catel.Data.IPropertyData TextProperty;
        public static readonly Catel.Data.IPropertyData WatermarkProperty;
        public WatermarkTextBoxModel(Orc.Automation.AutomationElementAccessor accessor) { }
        public bool SelectAllOnGotFocus { get; set; }
        public string Text { get; set; }
        public string Watermark { get; set; }
    }
}
namespace Orc.Controls.Automation.Converters
{
    public class BusinessRuleValidationResultSerializableConverter : Orc.Automation.SerializationValueConverterBase<Catel.Data.BusinessRuleValidationResult, Orc.Controls.Automation.Converters.SerializableBusinessRuleValidationResult>
    {
        public BusinessRuleValidationResultSerializableConverter() { }
        public override object ConvertFrom(Catel.Data.BusinessRuleValidationResult value) { }
        public override object ConvertTo(Orc.Controls.Automation.Converters.SerializableBusinessRuleValidationResult value) { }
    }
    public class FieldValidationResultSerializableConverter : Orc.Automation.SerializationValueConverterBase<Catel.Data.FieldValidationResult, Orc.Controls.Automation.Converters.SerializableFieldValidationResult>
    {
        public FieldValidationResultSerializableConverter() { }
        public override object ConvertFrom(Catel.Data.FieldValidationResult value) { }
        public override object ConvertTo(Orc.Controls.Automation.Converters.SerializableFieldValidationResult value) { }
    }
    public class NumberConverter : Orc.Automation.SerializationValueConverterBase<Orc.Controls.Number, Orc.Controls.Automation.Converters.SerializableNumber>
    {
        public NumberConverter() { }
        public override object ConvertFrom(Orc.Controls.Number value) { }
        public override object ConvertTo(Orc.Controls.Automation.Converters.SerializableNumber value) { }
    }
    public class SerializableBusinessRuleValidationResult
    {
        public SerializableBusinessRuleValidationResult() { }
        public string Message { get; set; }
        public object Tag { get; set; }
        public Catel.Data.ValidationResultType ValidationType { get; set; }
    }
    public class SerializableFieldValidationResult
    {
        public SerializableFieldValidationResult() { }
        public string Message { get; set; }
        public string PropertyName { get; set; }
        public object Tag { get; set; }
        public Catel.Data.ValidationResultType ValidationType { get; set; }
    }
    public class SerializableNumber
    {
        public SerializableNumber() { }
        public double DValue { get; set; }
        public Orc.Automation.Converters.SerializableType Type { get; set; }
    }
    public class SerializableValidationContext
    {
        public SerializableValidationContext() { }
        public System.Collections.Generic.List<Orc.Controls.Automation.Converters.SerializableBusinessRuleValidationResult> BusinessRuleResults { get; set; }
        public System.Collections.Generic.List<Orc.Controls.Automation.Converters.SerializableFieldValidationResult> FieldRuleResults { get; set; }
    }
    public class ValidationContextSerializableConverter : Orc.Automation.SerializationValueConverterBase<Catel.Data.ValidationContext, Orc.Controls.Automation.Converters.SerializableValidationContext>
    {
        public ValidationContextSerializableConverter() { }
        public override object ConvertFrom(Catel.Data.ValidationContext value) { }
        public override object ConvertTo(Orc.Controls.Automation.Converters.SerializableValidationContext value) { }
    }
}
namespace Orc.Controls.Converters
{
    public class BooleanAndToCollapsingVisibilityMultiValueConverter : System.Windows.Markup.MarkupExtension, System.Windows.Data.IMultiValueConverter
    {
        public BooleanAndToCollapsingVisibilityMultiValueConverter() { }
        public object Convert(object[] values, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) { }
        public override object ProvideValue(System.IServiceProvider serviceProvider) { }
    }
    public class NumberTypeConverter : System.ComponentModel.TypeConverter
    {
        public NumberTypeConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { }
    }
    public class TextToTextArrayMultiValueConverter : System.Windows.Data.IMultiValueConverter
    {
        public TextToTextArrayMultiValueConverter() { }
        public object Convert(object[] values, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class TreeViewItemToLeftMarginValueConverter : Catel.MVVM.Converters.ValueConverterBase
    {
        public TreeViewItemToLeftMarginValueConverter() { }
        public double Length { get; set; }
        protected override object Convert(object value, System.Type targetType, object parameter) { }
    }
    public class YearLongToYearShortConverter : Catel.MVVM.Converters.ValueConverterBase
    {
        public YearLongToYearShortConverter() { }
        public bool IsEnabled { get; set; }
        protected override object Convert(object value, System.Type targetType, object parameter) { }
        protected override object ConvertBack(object value, System.Type targetType, object parameter) { }
    }
}
namespace Orc.Controls.Enums
{
    public enum Meridiem
    {
        AM = 0,
        PM = 1,
    }
}
namespace Orc.Controls.Services
{
    public interface IFindReplaceService
    {
        bool FindNext(string textToFind, Orc.Controls.FindReplaceSettings settings);
        string GetInitialFindText();
        bool Replace(string textToFind, string textToReplace, Orc.Controls.FindReplaceSettings settings);
        void ReplaceAll(string textToFind, string textToReplace, Orc.Controls.FindReplaceSettings settings);
    }
    public interface IStatusRepresenter
    {
        void UpdateStatus(string status);
    }
    public interface ITextInputWindowService
    {
        System.Threading.Tasks.Task<Orc.Controls.TextInputDialogResult> ShowDialogAsync(string title, string initialText);
    }
    public class TextInputWindowService : Orc.Controls.Services.ITextInputWindowService
    {
        public TextInputWindowService(Catel.IoC.ITypeFactory typeFactory, Catel.Services.IUIVisualizerService uiVisualizerService) { }
        public System.Threading.Tasks.Task<Orc.Controls.TextInputDialogResult> ShowDialogAsync(string title, string initialText) { }
    }
}
namespace Orc.Controls.Tools.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class ToolSettingsAttribute : System.Attribute
    {
        public ToolSettingsAttribute() { }
        public string Storage { get; set; }
    }
}
namespace Orc.Controls.Tools
{
    public class ControlToolManager : Orc.Controls.Tools.IControlToolManager
    {
        public ControlToolManager(System.Windows.FrameworkElement frameworkElement, Catel.IoC.ITypeFactory typeFactory, Orc.FileSystem.IDirectoryService directoryService) { }
        public System.Collections.Generic.IList<Orc.Controls.IControlTool> Tools { get; }
        public event System.EventHandler<Orc.Controls.Tools.ToolManagementEventArgs> ToolAttached;
        public event System.EventHandler<Orc.Controls.Tools.ToolManagementEventArgs> ToolClosed;
        public event System.EventHandler<Orc.Controls.Tools.ToolManagementEventArgs> ToolDetached;
        public event System.EventHandler<Orc.Controls.Tools.ToolManagementEventArgs> ToolOpened;
        public event System.EventHandler<Orc.Controls.Tools.ToolManagementEventArgs> ToolOpening;
        public object AttachTool(System.Type toolType) { }
        public bool CanAttachTool(System.Type toolType) { }
        public bool DetachTool(System.Type toolType) { }
        protected virtual void LoadSettings(Orc.Controls.IControlTool tool) { }
        protected virtual void SaveSettings(Orc.Controls.IControlTool tool) { }
    }
    public class ControlToolManagerFactory : Orc.Controls.Tools.IControlToolManagerFactory
    {
        public ControlToolManagerFactory(Catel.IoC.ITypeFactory typeFactory) { }
        public Orc.Controls.Tools.IControlToolManager GetOrCreateManager(System.Windows.FrameworkElement frameworkElement) { }
    }
    public interface IControlToolManager
    {
        System.Collections.Generic.IList<Orc.Controls.IControlTool> Tools { get; }
        event System.EventHandler<Orc.Controls.Tools.ToolManagementEventArgs> ToolAttached;
        event System.EventHandler<Orc.Controls.Tools.ToolManagementEventArgs> ToolClosed;
        event System.EventHandler<Orc.Controls.Tools.ToolManagementEventArgs> ToolDetached;
        event System.EventHandler<Orc.Controls.Tools.ToolManagementEventArgs> ToolOpened;
        event System.EventHandler<Orc.Controls.Tools.ToolManagementEventArgs> ToolOpening;
        object AttachTool(System.Type toolType);
        bool CanAttachTool(System.Type toolType);
        bool DetachTool(System.Type toolType);
    }
    public interface IControlToolManagerFactory
    {
        Orc.Controls.Tools.IControlToolManager GetOrCreateManager(System.Windows.FrameworkElement frameworkElement);
    }
    public class ToolManagementEventArgs : System.EventArgs
    {
        public ToolManagementEventArgs(Orc.Controls.IControlTool tool) { }
        public Orc.Controls.IControlTool Tool { get; }
    }
}
namespace Orc.Controls.ViewModels
{
    public class FindReplaceViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData TextToFindForReplaceProperty;
        public static readonly Catel.Data.IPropertyData TextToFindProperty;
        public FindReplaceViewModel(Orc.Controls.FindReplaceSettings findReplaceSettings, Orc.Controls.Services.IFindReplaceService findReplaceService) { }
        public Catel.MVVM.Command<string> FindNext { get; }
        [Catel.MVVM.Model]
        public Orc.Controls.FindReplaceSettings FindReplaceSettings { get; }
        public Catel.MVVM.Command<object> Replace { get; }
        public Catel.MVVM.Command<object> ReplaceAll { get; }
        public string TextToFind { get; set; }
        public string TextToFindForReplace { get; set; }
        public override string Title { get; }
    }
    public class LogViewerViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData ActiveFilterGroupProperty;
        public static readonly Catel.Data.IPropertyData AutoScrollProperty;
        public static readonly Catel.Data.IPropertyData DebugEntriesCountProperty;
        public static readonly Catel.Data.IPropertyData ErrorEntriesCountProperty;
        public static readonly Catel.Data.IPropertyData IgnoreCatelLoggingProperty;
        public static readonly Catel.Data.IPropertyData InfoEntriesCountProperty;
        public static readonly Catel.Data.IPropertyData LogFilterProperty;
        public static readonly Catel.Data.IPropertyData LogListenerTypeProperty;
        public static readonly Catel.Data.IPropertyData MaximumUpdateBatchSizeProperty;
        public static readonly Catel.Data.IPropertyData ScrollModeProperty;
        public static readonly Catel.Data.IPropertyData ShowDebugProperty;
        public static readonly Catel.Data.IPropertyData ShowErrorProperty;
        public static readonly Catel.Data.IPropertyData ShowInfoProperty;
        public static readonly Catel.Data.IPropertyData ShowMultilineMessagesExpandedProperty;
        public static readonly Catel.Data.IPropertyData ShowWarningProperty;
        public static readonly Catel.Data.IPropertyData TypeFilterProperty;
        public static readonly Catel.Data.IPropertyData TypeNamesProperty;
        public static readonly Catel.Data.IPropertyData WarningEntriesCountProperty;
        public LogViewerViewModel(Catel.IoC.ITypeFactory typeFactory, Catel.Services.IDispatcherService dispatcherService, Orc.Controls.LogViewerLogListener logViewerLogListener, Catel.Services.ILanguageService languageService) { }
        public Orc.Controls.LogFilterGroup ActiveFilterGroup { get; set; }
        public bool AutoScroll { get; set; }
        public int DebugEntriesCount { get; }
        public int ErrorEntriesCount { get; }
        public bool IgnoreCatelLogging { get; set; }
        public int InfoEntriesCount { get; }
        public System.Collections.ObjectModel.ObservableCollection<Catel.Logging.LogEntry> LogEntries { get; }
        public string LogFilter { get; set; }
        public System.Type LogListenerType { get; set; }
        public int MaximumUpdateBatchSize { get; set; }
        public Orc.Controls.ScrollMode ScrollMode { get; set; }
        public bool ShowDebug { get; set; }
        public bool ShowError { get; set; }
        public bool ShowInfo { get; set; }
        public bool ShowMultilineMessagesExpanded { get; set; }
        public bool ShowWarning { get; set; }
        public string TypeFilter { get; set; }
        public Catel.Collections.FastObservableCollection<string> TypeNames { get; }
        public int WarningEntriesCount { get; }
        public event System.EventHandler<System.EventArgs> ActiveFilterGroupChanged;
        public event System.EventHandler<Orc.Controls.LogEntryEventArgs> LogMessage;
        public void ClearEntries() { }
        protected override System.Threading.Tasks.Task CloseAsync() { }
        public System.Collections.Generic.IEnumerable<Catel.Logging.LogEntry> GetFilteredLogEntries() { }
        protected override System.Threading.Tasks.Task InitializeAsync() { }
        public bool IsValidLogEntry(Catel.Logging.LogEntry logEntry) { }
    }
    public class TextInputViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.IPropertyData TextProperty;
        public TextInputViewModel(string title) { }
        public string Text { get; set; }
    }
}
namespace Orc.Controls.Views
{
    public class FindReplaceView : Catel.Windows.DataWindow, System.Windows.Markup.IComponentConnector
    {
        public FindReplaceView() { }
        public void InitializeComponent() { }
    }
    public class TextInputWindow : Catel.Windows.DataWindow, System.Windows.Markup.IComponentConnector
    {
        public TextInputWindow() { }
        public void InitializeComponent() { }
    }
}
namespace XamlGeneratedNamespace
{
    public sealed class GeneratedInternalTypeHelper : System.Windows.Markup.InternalTypeHelper
    {
        public GeneratedInternalTypeHelper() { }
        protected override void AddEventHandler(System.Reflection.EventInfo eventInfo, object target, System.Delegate handler) { }
        protected override System.Delegate CreateDelegate(System.Type delegateType, object target, string handler) { }
        protected override object CreateInstance(System.Type type, System.Globalization.CultureInfo culture) { }
        protected override object GetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, System.Globalization.CultureInfo culture) { }
        protected override void SetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, object value, System.Globalization.CultureInfo culture) { }
    }
}