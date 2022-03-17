Module Module1

    Sub Main()
        ' Declare a single-dimension array of 5 numbers.
        Dim numbers(4) As Integer

        ' Declare a single-dimension array and set its 4 values.
        Dim anotherArray = New Integer() {1, 2, 4, 8}

        ' Change the size of an existing array to 16 elements and retain the current values.
        ReDim Preserve numbers(15)

        ' Redefine the size of an existing array and reset the values.
        ReDim numbers(15)

        ' Declare a 6 x 6 multidimensional array.
        Dim matrix(5, 5) As Double

        ' Declare a 4 x 3 multidimensional array and set array element values.
        Dim anotherMatrix = New Integer(3, 2) {{1, 2, 3}, {2, 3, 4}, {3, 4, 5}, {4, 5, 6}}

        ' Declare a jagged array
        Dim sales()() As Double = New Double(11)() {}

    End Sub



End Module
