﻿#pragma checksum "D:\Projects\GuessMe\GuessMe\view\AddWordPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EAD41FCF4DADE86F5F5C558E1BC4736F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuessMe
{
    partial class AddWordPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.AddWord = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.OK = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\view\AddWordPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.OK).Click += this.OK_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\view\AddWordPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.Back_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.Word = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.WordText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.Difficulty = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.Questionable = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.Drawable = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.Pantomimable = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.Medium = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 11:
                {
                    this.Hard = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 12:
                {
                    this.QYes = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 13:
                {
                    this.QNo = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 14:
                {
                    this.DYes = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 15:
                {
                    this.DNo = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 16:
                {
                    this.PYes = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 17:
                {
                    this.PNo = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

