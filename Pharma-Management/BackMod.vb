Module BackMod

    Public Sub Back(currentForm As Form)
        currentForm.Hide()
        Dim home As New Home
        home.Show()
    End Sub

    Public Sub LogOff(currentForm As Form)
        currentForm.Hide()
        Dim log = New LoginForm
        log.Show()
    End Sub

End Module
