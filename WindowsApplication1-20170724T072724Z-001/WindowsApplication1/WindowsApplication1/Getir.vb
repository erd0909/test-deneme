Public Class Getir
    Dim Döner, Pizza, Hamburger, Pilav, Köfte, Patetes, Patlıcan, Yoğurt, Tavuk, Et, Sucuk, Ekmek, İcetea, Kola, Pepsi, Gazoz, Ayran, Meyve, Su, Süt, Hoşbeş, kat, pop, ülker, Piko, Crax, Nutela, konflex, Mac, Windows, WindowsP, WindowsPR, WindowsPRO
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()

        If ComboBox1.Text = "Yemek" Then

            ComboBox2.Items.Add("Döner")

            ComboBox2.Items.Add("Pizza")

            ComboBox2.Items.Add("Hamburger")

            ComboBox2.Items.Add("Pilav")

            ComboBox2.Items.Add("Köfte")

            ComboBox2.Items.Add("Patates")

            ComboBox2.Items.Add("Patlıcan")

            ComboBox2.Items.Add("Yoğurt")

            ComboBox2.Items.Add("Tavuk")

            ComboBox2.Items.Add("Et")

            ComboBox2.Items.Add("Sucuk")

            ComboBox2.Items.Add("Ekmek")

        ElseIf ComboBox1.Text = "İçicek" Then

            ComboBox2.Items.Add("İcetea")

            ComboBox2.Items.Add("Kola")

            ComboBox2.Items.Add("Pepsi")

            ComboBox2.Items.Add("Gazoz")

            ComboBox2.Items.Add("Ayran")

            ComboBox2.Items.Add("Meyve Suy")

            ComboBox2.Items.Add("Su")

            ComboBox2.Items.Add("Süt")

        ElseIf ComboBox1.Text = "Aburcubur" Then

            ComboBox2.Items.Add("Hoşbeş")

            ComboBox2.Items.Add("9 kat")

            ComboBox2.Items.Add("pop kek")

            ComboBox2.Items.Add("Ülker çikolata")

            ComboBox2.Items.Add("Piko")

            ComboBox2.Items.Add("Crax")

            ComboBox2.Items.Add("Nutela")

            ComboBox2.Items.Add("konflex")

        ElseIf ComboBox1.Text = "Bilgisayar" Then

            ComboBox2.Items.Add("Mac")

            ComboBox2.Items.Add("Windows 7 Pro")

            ComboBox2.Items.Add("Windows 10")

            ComboBox2.Items.Add("Windows 10 Pro")

            ComboBox2.Items.Add("Windows 8")

        ElseIf ComboBox1.Text = "Telefon" Then

            ComboBox2.Items.Add("Iphone 5s")

            ComboBox2.Items.Add("Iphone 6")

            ComboBox2.Items.Add("Iphone 7")

            ComboBox2.Items.Add("Iphone 7 plus")

            ComboBox2.Items.Add("Note 3")



            ComboBox2.Items.Add("Note 4")

            ComboBox2.Items.Add("Samsung")

            ComboBox2.Items.Add("Lg")








        End If

    End Sub
End Class
