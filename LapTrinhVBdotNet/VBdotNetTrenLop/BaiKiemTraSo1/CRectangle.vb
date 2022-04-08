Public Class CRectangle
    Inherits CShape
    Private width As Double
    Private length As Double
    Public Sub New()
        MyBase.New()
        width = 3
        length = 4
    End Sub
    Public Sub New(ByVal width As Double, ByVal length As Double)
        MyBase.New()
        Me.width = width
        Me.length = length
    End Sub
    Public Sub New(ByVal width As Double, ByVal length As Double, ByVal color As String, ByVal filled As Boolean)
        MyBase.New(color, filled)
        Me.width = width
        Me.length = length
    End Sub
    Public Property SetWidth() As Double
        Get
            Return Me.width
        End Get
        Set(value As Double)
            Me.width = value
        End Set
    End Property
    Public Property SetLength() As Double
        Get
            Return Me.length
        End Get
        Set(value As Double)
            Me.length = value
        End Set
    End Property
    Public Overrides Function GetArea() As Double
        Return Me.width * Me.length
    End Function
    Public Overrides Function GetPerimeter() As Double
        Return 2 * (Me.width + Me.length)
    End Function
    Public Overrides Function ToString() As String
        Return $"color: {Me.color}, is filled: {filled}, width: {Me.width}, length: {Me.length}"
    End Function
End Class
