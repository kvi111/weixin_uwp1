﻿#pragma checksum "D:\VSProjects\weixin_uwp\weixin_uwp\weixin_uwp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "86F342CEDD376771C7669AEA82429BCE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace weixin_uwp
{
    partial class MainPage : 
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 8 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.sessionList1 = (global::weixin_uwp.Controls.ContactList)(target);
                    #line 37 "..\..\..\MainPage.xaml"
                    ((global::weixin_uwp.Controls.ContactList)this.sessionList1).SelectionChanged += this.sessionList1_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.contactList1 = (global::weixin_uwp.Controls.ContactList)(target);
                    #line 38 "..\..\..\MainPage.xaml"
                    ((global::weixin_uwp.Controls.ContactList)this.contactList1).SelectionChanged += this.contactList1_SelectionChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.textBlockNickName = (global::weixin_uwp.Controls.EmojiTextControl)(target);
                }
                break;
            case 5:
                {
                    this.sp1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6:
                {
                    this.chatlist1 = (global::weixin_uwp.Controls.ChatListControl)(target);
                }
                break;
            case 7:
                {
                    this.textBoxInput = (global::weixin_uwp.Controls.WeiXinTextInput)(target);
                }
                break;
            case 8:
                {
                    this.spWelcome = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.btnUser = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnUser).Click += this.btnUser_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.btnSessionList = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSessionList).Click += this.btnSessionList_Click;
                    #line 26 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSessionList).GotFocus += this.btnSessionList_GotFocus;
                    #line default
                }
                break;
            case 11:
                {
                    this.btnContactList = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnContactList).Click += this.btnContactList_Click;
                    #line 29 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnContactList).GotFocus += this.btnContactList_GotFocus;
                    #line default
                }
                break;
            case 12:
                {
                    this.btnContactListImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 13:
                {
                    this.btnSessionListImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 14:
                {
                    this.btnUserImage = (global::Windows.UI.Xaml.Controls.Image)(target);
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

