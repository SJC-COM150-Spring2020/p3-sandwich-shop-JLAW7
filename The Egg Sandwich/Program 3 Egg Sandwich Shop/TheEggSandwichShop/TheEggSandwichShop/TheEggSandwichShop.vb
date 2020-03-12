Public Class TheEggSandwichShop
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Declare and then initialize beverages
        Dim Beverages As Double
        Beverages = 0
        lstOrder.Items.Add("BEVERAGES: ")

        'check for optional items that are checked and output them to list box

        'check for Coffee
        If (chkCoffee.Checked = True) Then
            lstOrder.Items.Add("Coffee - $2.25")
            Beverages = Beverages + 2.25
        End If

        'check for Tea
        If (chkTea.Checked = True) Then
            lstOrder.Items.Add("Tea - $2.25")
            Beverages = Beverages + 2.25
        End If

        'check for Hot Chocolate
        If (chkHotChocolate.Checked = True) Then
            lstOrder.Items.Add("Hot Chocolate - $2.25")
            Beverages = Beverages + 2.25
        End If

        'check for Milk
        If (chkMilk.Checked = True) Then
            lstOrder.Items.Add("Milk - $2.25")
            Beverages = Beverages + 2.25
        End If

        'check for Juice
        If (chkJuice.Checked = True) Then
            lstOrder.Items.Add("Juice - $2.25")
            Beverages = Beverages + 2.25
        End If

        lstOrder.Items.Add("")

        'Declare and initilize sandwiches and output them to list box
        Dim Sandwiches As Double
        Sandwiches = 0
        lstOrder.Items.Add("SANDWICHES: ")


        'Selected scrambled

        If (radScrambled.Checked = True) Then
            lstOrder.Items.Add("Scrambled - $6.95")
            Sandwiches = Sandwiches + 6.95
        End If


        'Selected over easy

        If (radOverEasy.Checked = True) Then
            lstOrder.Items.Add("Over Easy - $6.95")
            Sandwiches = Sandwiches + 6.95
        End If

        'Selected Sunny Side Up

        If (radSunnySideUp.Checked = True) Then
            lstOrder.Items.Add("Sunny Side Up - $6.95")
            Sandwiches = Sandwiches + 6.95
        End If

        'Selected poached

        If (radPoached.Checked = True) Then
            lstOrder.Items.Add("Poached - $6.95")
            Sandwiches = Sandwiches + 6.95
        End If

        lstOrder.Items.Add("")

        'Declare and then initialize extras

        Dim Extras As Double
        Extras = 0
        lstOrder.Items.Add("EXTRAS: ")

        'check for optional items that are checked and output them to list box

        'check for Cheese

        If (chkCheese.Checked = True) Then
            lstOrder.Items.Add("Cheese - $1.50")
            Extras = Extras + 1.5
        End If

        'check for Bacon

        If (chkBacon.Checked = True) Then
            lstOrder.Items.Add("Bacon - $1.50")
            Extras = Extras + 1.5
        End If

        'check for sausage

        If (chkSausage.Checked = True) Then
            lstOrder.Items.Add("Sausage - $1.50")
            Extras = Extras + 1.5
        End If

        'check for Ham

        If (chkHam.Checked = True) Then
            lstOrder.Items.Add("Ham- $1.50")
            Extras = Extras + 1.5
        End If

        'check for veggies

        If (chkVeggies.Checked = True) Then
            lstOrder.Items.Add("Veggies - $1.50")
            Extras = Extras + 1.5
        End If

        lstOrder.Items.Add("")

        'Declare and initialize subtotal & output to listbox

        Dim Subtotal As Double
        Subtotal = Beverages + Sandwiches + Extras
        lstOrder.Items.Add("SUBTOTAL: " & FormatCurrency(Subtotal, 2))


        'Declare Tax as Constant & Output to list box

        Const T As Double = 0.08875
        Dim Tax As Double
        Tax = Subtotal * T
        lstOrder.Items.Add("TAX: " & FormatCurrency(Tax, 2))
        lstOrder.Items.Add("")


        'Declare and initialize Total & output to listbox

        Dim Total As Double
        Total = Subtotal + Tax
        lstOrder.Items.Add("TOTAL: " & FormatCurrency(Total, 2))







    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOrder.Items.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Beep()
        Application.Exit()
    End Sub


End Class
