#pragma checksum "..\..\VisitWorkoutWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D488C04AD217ACFBF3A35E95B5FF4B0E7F2A3BA067A0FDAF0E55D623D1A90295"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using UI;


namespace UI {
    
    
    /// <summary>
    /// VisitWorkoutWindow
    /// </summary>
    public partial class VisitWorkoutWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\VisitWorkoutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboxUsers;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\VisitWorkoutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboxClubs;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\VisitWorkoutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstname;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\VisitWorkoutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboxWorkouts;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\VisitWorkoutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox address;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\VisitWorkoutWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox city;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UI;component/visitworkoutwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VisitWorkoutWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.comboxUsers = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\VisitWorkoutWindow.xaml"
            this.comboxUsers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxUsers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboxClubs = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\VisitWorkoutWindow.xaml"
            this.comboxClubs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxClubs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\VisitWorkoutWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_VisitWorkout);
            
            #line default
            #line hidden
            return;
            case 4:
            this.firstname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.comboxWorkouts = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.address = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.city = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

