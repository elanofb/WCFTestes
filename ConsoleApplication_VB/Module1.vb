Module Module1

    Sub Main()

        Dim array(2) As String
        array(0) = "7002"
        array(1) = "7003"
        array(2) = "7004"

        Dim x As Class1 = New Class1()

        'Console.WriteLine(Join(array, ","))

        Console.WriteLine(x.GetElementSetByArraySimple("[CustomProduct].[idDimProduct].&[@Value]", Join(array, ","), "[CustomProduct].[idDimProduct].[All]"))



    End Sub

End Module
