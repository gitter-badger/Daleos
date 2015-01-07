Imports NUnit.Framework
Imports HoracioFilho.Daleos.HashMap(Of Integer, String)

<TestFixture>
Public NotInheritable Class HashMapTests
    <TestCase(0, ExpectedResult:=1)>
    <TestCase(3675515, ExpectedResult:=4194304)>
    <TestCase(7735535, ExpectedResult:=8388608)>
    <TestCase(9743925, ExpectedResult:=16777216)>
    <TestCase(106020445, ExpectedResult:=134217728)>
    <TestCase(203295678, ExpectedResult:=268435456)>
    <TestCase(386281800, ExpectedResult:=536870912)>
    <TestCase(962308314, ExpectedResult:=1073741824)>
    <TestCase(MaximumCapacity, ExpectedResult:=MaximumCapacity)>
    <TestCase(Integer.MaxValue, ExpectedResult:=MaximumCapacity)>
    Public Function TestThresholdCalculation(capacity As Integer) As Integer
        Return ThresholdFor(capacity)
    End Function
End Class