Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Public Interface IMap(Of TKey, TValue)
    Inherits ICollection(Of KeyValuePair(Of TKey, TValue))

    Default Property Item(key As TKey) As TValue
    ReadOnly Property Keys As ICollection(Of TKey)
    ReadOnly Property Values As ICollection(Of TValue)
    Overloads Sub Add(key As TKey, value As TValue)
    Function ContainsKey(key As TKey) As Boolean
    Overloads Function Remove(key As TKey) As Boolean
    Function TryGetValue(key As TKey, <Out> ByRef value As TValue) As Boolean
End Interface