Imports NUnit.Framework
Imports HoracioFilho.Daleos.HashMap(Of Integer, String)

<TestFixture>
Public NotInheritable Class HashMapTests
    <TestCase(0, ExpectedResult:=1)>
    <TestCase(5, ExpectedResult:=8)>
    <TestCase(10, ExpectedResult:=16)>
    <TestCase(20, ExpectedResult:=32)>
    <TestCase(MaximumCapacity, ExpectedResult:=MaximumCapacity)>
    <TestCase(Integer.MaxValue, ExpectedResult:=MaximumCapacity)>
    Public Function TestThresholdForMethod(capacity As Integer) As Integer
        Return ThresholdFor(capacity)
    End Function
End Class