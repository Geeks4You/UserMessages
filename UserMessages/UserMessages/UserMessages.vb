Public Class UserMessages
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        ' Display the Spanish word for one.
        ' MessageBox.Show("uno")
        lblStatus.Text = "uno"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        ' Display the Spanish word for two.
        ' MessageBox.Show("dos")
        lblStatus.Text = "dos"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        ' Display the Spanish word for three.
        MessageBox.Show("tres")
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        ' Display the Spanish word for four.
        MessageBox.Show("cuatro")
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        ' Display the Spanish word for five.
        MessageBox.Show("cinco")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub UserMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
