Imports CefSharp
Imports Microsoft.Win32
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions
Imports CefSharp.WinForms.CefSettings
Imports CefSharp.WinForms
Imports System.Runtime.InteropServices
Imports CefSharp.DevTools
Imports CefSharp.DevTools.Page
Imports System.Runtime.InteropServices.ExternalException

Public Class ibrahimcelik

    'yo19
    'Reedited & updated for 64 bit by software developer IBRAHIM CELIK
    'YouTube: @devibrahimcelik | : https://www.youtube.com/@devibrahimcelik
    'Github: https://github.com/SoftwareDEVibrahimcelik
    'Instagram: softwaredevic
    'Donate Bitcoin Address: 3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk



    Private Sub ibrahimcelik_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Cef.GetGlobalCookieManager().DeleteCookies("", "")

        Me.Size = New Size(2705, 1608)


    End Sub

    Private WithEvents browser As ChromiumWebBrowser



    Public Sub New()
        InitializeComponent()
        Dim settings As New CefSettings()
        '
        settings.CefCommandLineArgs.Add("disable-3rd-party-cookies", "0")
        settings.CefCommandLineArgs.Add("disable-image-loading", "1")
        settings.CefCommandLineArgs.Add("mute-audio")




        '
        CefSharp.Cef.Initialize(settings)

        browser = New ChromiumWebBrowser("https://store.steampowered.com/login/") With {
            .Dock = DockStyle.Fill
        }
        ChromiumWebBrowser1.Controls.Add(browser)
        browser.Dock = DockStyle.Fill
        Timer1.Start()
        AddHandler browser.FrameLoadEnd, AddressOf FrameLoaded
    End Sub



    Private Sub FrameLoaded(sender As Object, e As FrameLoadEndEventArgs)



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'You need to get 'addtocart' button id from steam game pages...
        browser.ExecuteScriptAsync("addToCart(45549); addToCart(74002); addToCart(213185); addToCart(111113); addToCart(117458); addToCart(96994); addToCart(96994); addToCart(165867); addToCart(96994); addToCart(189289); addToCart(195824); addToCart(249023); addToCart(354552); addToCart(371737); addToCart(371819); addToCart(391764); addToCart(399411); addToCart(410041); addToCart(419480); addToCart(543624); addToCart(552512); addToCart(85819); addToCart(386888); addToCart(212715); addToCart(387773); addToCart(38690); addToCart(144399); addToCart(35999); addToCart(52512); addToCart(143197); addToCart(484025); addToCart(92277); addToCart(306628); addToCart(44117); addToCart(65178); addToCart(95807); addToCart(552965); addToCart(577461); addToCart(1596); addToCart(30867); addToCart(76056); addToCart(115596); addToCart(382481); addToCart(44120); addToCart(475059); addToCart(388041); addToCart(413333); addToCart(121); addToCart(126); addToCart(127); addToCart(123); addToCart(124); addToCart(265); addToCart(1051); addToCart(2079); addToCart(6217); addToCart(2258); addToCart(6812); addToCart(6615); addToCart(18532); addToCart(15714); addToCart(15376); addToCart(30888); addToCart(31560); addToCart(32275); addToCart(49817); addToCart(51708); addToCart(59898); addToCart(84542); addToCart(85370); addToCart(91104); addToCart(92315); addToCart(94528); addToCart(97318); addToCart(101346); addToCart(109772); addToCart(116012); addToCart(119798); addToCart(147478); addToCart(151272); addToCart(488914); addToCart(498269); addToCart(515851); addToCart(995876); addToCart(995870); addToCart(1041477); addToCart(998005); addToCart(1006563); addToCart(402134);")

    End Sub





    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        browser.ExecuteScriptAsync("
            const removeButtons = document.querySelectorAll('div._33j4SwfO2YH9eI6qV9BKaL.Panel.Focusable'); // Kaldırma düğmelerini seç
            // Her bir kaldırma düğmesine tıkla
            removeButtons.forEach(removeButton => {
                removeButton.click(); // Kaldırma düğmesine tıkla
            });
        ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim script As String = "
            const gameDivs = document.querySelectorAll('div.jRg6Oo9hDgKCGaXi9NJvU');
            gameDivs.forEach(gameDiv => {
                const ownedMessage = gameDiv.querySelector('div._1PZ2hvQoEPUrRR-9jaAMBK');
                if (ownedMessage) {
                    const removeButton = gameDiv.querySelector('div._33j4SwfO2YH9eI6qV9BKaL.Panel.Focusable');
                    if (removeButton) {
                        removeButton.click();
                    }
                }
            });
        "

        browser.ExecuteScriptAsync(script)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        browser.ExecuteScriptAsync("
            (function() {
                const gameDivs = document.querySelectorAll('div.jRg6Oo9hDgKCGaXi9NJvU');
                gameDivs.forEach(function(gameDiv) {
                    const discountElement = gameDiv.querySelector('span.StoreSaleDiscountBox');
                    if (!discountElement) {
                        const removeButton = gameDiv.querySelector('div._33j4SwfO2YH9eI6qV9BKaL.Panel.Focusable');
                        if (removeButton) {
                            removeButton.click();
                        }
                    }
                });
            })()")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Clipboard.SetDataObject("3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk")
        MsgBox("YOU COPIED IBRAHIM CELIK IS BITCOIN ADDRESS")

        System.Diagnostics.Process.Start("https://www.youtube.com/channel/@devibrahimcelik")

    End Sub
End Class