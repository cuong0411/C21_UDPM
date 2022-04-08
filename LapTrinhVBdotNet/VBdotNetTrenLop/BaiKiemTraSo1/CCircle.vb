Public Class CCircle
    Inherits CShape
    Private radius As Double
    Public Sub New()
        MyBase.New()
        Me.radius = 0.0
    End Sub
    Public Sub New(ByVal radius As Double)
        MyBase.New()
        Me.radius = radius
    End Sub
    Public Property NhapRadius() As Double
        Get
            Return radius
        End Get
        Set(value As Double)
            Me.radius = value
        End Set
    End Property
    Public Overrides Function GetArea() As Double
        Return MyBase.GetArea()
    End Function

End Class
