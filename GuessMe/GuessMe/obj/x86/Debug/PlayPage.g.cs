﻿#pragma checksum "D:\Projects\GuessMe\GuessMe\PlayPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "17409CCCE571C5376407918A04566D11"
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
    partial class PlayPage : 
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
                    this.Play = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.NumberOfTeams = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this._2Team = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 4:
                {
                    this._3Team = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 5:
                {
                    this._4Team = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 6:
                {
                    this._5Team = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 7:
                {
                    this.Difficulty = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.OK = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\PlayPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.OK).Click += this.OK_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\PlayPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.Back_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.Meduim = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 11:
                {
                    this.Hard = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 12:
                {
                    this.Easy = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 13:
                {
                    this.Extreme = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
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

