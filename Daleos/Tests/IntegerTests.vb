Imports NUnit.Framework

<TestFixture>
Public NotInheritable Class IntegerTests
    <TestCase(Integer.MinValue, 1509303017, ExpectedResult:=4194304)>
    <TestCase(-1872085434, 238572621, ExpectedResult:=295761)>
    <TestCase(-1383940216, -1517775405, ExpectedResult:=5552)>
    <TestCase(-731139318, 1066104648, ExpectedResult:=13921203)>
    <TestCase(-618061730, 1500651589, ExpectedResult:=114903298)>
    <TestCase(426002082, 572205621, ExpectedResult:=203)>
    <TestCase(826042896, 681493843, ExpectedResult:=1575)>
    <TestCase(883738867, -403003839, ExpectedResult:=441869433)>
    <TestCase(1610932764, -1151583905, ExpectedResult:=0)>
    <TestCase(Integer.MaxValue, -1656451440, ExpectedResult:=32767)>
    Public Function TestURightShiftOperation(operand As Integer, n As Integer) As Integer
        Return operand.URightShift(n)
    End Function
End Class