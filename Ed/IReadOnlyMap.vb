Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Public Interface IReadOnlyMap(Of TKey, TValue)
    Inherits IReadOnlyCollection(Of KeyValuePair(Of TKey, TValue))

    Default ReadOnly Property Item(key As TKey) As TValue
    ReadOnly Property Keys As IEnumerable(Of TKey)
    ReadOnly Property Values As IEnumerable(Of TValue)

    Function ContainsKey(key As TKey) As Boolean
    Function TryGetValue(key As TKey, <Out> ByRef value As TValue) As Boolean
End Interface