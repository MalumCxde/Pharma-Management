Module BackMod

    Public Sub Back(currentForm As Form)
        currentForm.Hide()
        Dim home As New Home
        home.Show()
    End Sub

End Module
