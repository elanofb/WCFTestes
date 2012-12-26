Public Class Class1

    Function GetElementSetByArraySimple(ByVal setFormat As String, ByVal value As Object, ByVal nothingvalue As String)
        Dim i As Integer
        Dim setValue As String
        Dim a As Array

        setValue = ""

        If IsNothing(value) Then
            Return nothingvalue
        Else
            a = Split(value, ",")
            For i = 0 To UBound(a)
                'setValue = setValue &amp; Replace(setFormat, "@Value", a(i).ToString() ) &amp; ","
                setValue = setValue & Replace(setFormat, "@Value", a(i).ToString()) & ","
            Next i
            'Return "{" &amp; Left(setValue, setValue.Length - 1) &amp; "}"
            Return "{" & Left(setValue, setValue.Length - 1) & "}"
        End If

        Return "---"
    End Function

End Class
