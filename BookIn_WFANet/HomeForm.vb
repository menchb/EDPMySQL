Public Class HomeForm
    Private Sub btnBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBook.Click
        With Me
            .Hide()
            BookForm.Show()
        End With

    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        With Me
            .Hide()
            CustomerForm.Show()
        End With
    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        With Me
            .Hide()
            AdminForm.Show()
        End With
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        With Me
            .Hide()
            OrderForm.Show()
        End With
    End Sub

End Class