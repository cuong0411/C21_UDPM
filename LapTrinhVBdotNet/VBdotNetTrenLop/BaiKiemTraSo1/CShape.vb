Public Class CShape
    Protected color As String
    Protected filled As Boolean
    Public Sub New()
        color = "None"
        filled = False
    End Sub
    Public Sub New(ByVal color As String, ByVal filled As Boolean)
        Me.color = color
        Me.filled = filled
    End Sub
    Public Property NhapColor() As String
        Get
            Return Me.color
        End Get
        Set(value As String)
            Me.color = value
        End Set
    End Property
    Public Property NhapFilled() As Boolean
        Get
            Return Me.filled
        End Get
        Set(value As Boolean)
            Me.filled = value
        End Set
    End Property
    Public Overridable Function GetArea() As Double
        Return 0
    End Function
    Public Overridable Function GetPerimeter() As Double
        Return 0
    End Function
    Public Overridable Overloads Function ToString() As String
        Return $"color: {Me.color}, is filled: {filled}"
    End Function


End Class
