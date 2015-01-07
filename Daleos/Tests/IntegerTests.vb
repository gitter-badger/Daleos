Imports NUnit.Framework

<TestFixture>
Public NotInheritable Class IntegerTests
    <TestCase(Integer.MinValue, 16, ExpectedResult:=32768)>
    <TestCase(-1641454136, 16, ExpectedResult:=40489)>
    <TestCase(-1630307160, 16, ExpectedResult:=40659)>
    <TestCase(-1370808903, 16, ExpectedResult:=44619)>
    <TestCase(-536525161, 16, ExpectedResult:=57349)>
    <TestCase(-68626434, 16, ExpectedResult:=64488)>
    <TestCase(7655189, 16, ExpectedResult:=116)>
    <TestCase(279493963, 16, ExpectedResult:=4264)>
    <TestCase(426948704, 16, ExpectedResult:=6514)>
    <TestCase(Integer.MaxValue, 16, ExpectedResult:=32767)>
    Public Function TestURightShiftMethod(operand As Integer, n As Integer) As Integer
        Return operand.URightShift(n)
    End Function
End Class