﻿using CodedSelenium.HtmlControls;
using OpenQA.Selenium.Interactions;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

namespace CodedSelenium
{
    public static class Mouse
    {
        public static void Click()
        {
            Click(BrowserWindow.ActiveBrowserWindow);
        }

        public static void Click(ModifierKeys modifierKeys)
        {
            Click(BrowserWindow.ActiveBrowserWindow, modifierKeys);
        }

        public static void Click(MouseButtons button)
        {
            Click(BrowserWindow.ActiveBrowserWindow, button);
        }

        public static void Click(MouseButtons button, ModifierKeys modifierKeys)
        {
            Click(BrowserWindow.ActiveBrowserWindow, button, modifierKeys);
        }

        public static void Click(Point screenCoordinate)
        {
            Click(BrowserWindow.ActiveBrowserWindow, screenCoordinate);
        }

        private static void Click(UITestControl control, Point screenCoordinate)
        {
            control.Click(MouseButtons.Left, ModifierKeys.None, screenCoordinate);
        }

        public static void Click(UITestControl control, MouseButtons button, ModifierKeys modifierKeys)
        {
            control.Click(button, modifierKeys, null);
        }

        public static void Click(UITestControl control, MouseButtons button)
        {
            control.Click(button, ModifierKeys.None, null);
        }

        public static void Click(UITestControl control, ModifierKeys modifierKeys)
        {
            control.Click(MouseButtons.Left, modifierKeys, null);
        }

        public static void Click(UITestControl control, MouseButtons button, ModifierKeys modifierKeys, Point relativeCoordinate)
        {
            control.Click(button, modifierKeys, relativeCoordinate);
        }

        public static void Click(UITestControl control)
        {
            control.Click(MouseButtons.Left, ModifierKeys.None, null);
        }
        
        public static void Move(UITestControl control, Point relativeCoordinate)
        {
            control.MoveToElement(relativeCoordinate);
        }
    }
}
