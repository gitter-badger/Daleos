Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

<ComVisible(False)>
Public Class HashMap(Of TKey, TValue)
    Implements IMap(Of TKey, TValue), IReadOnlyMap(Of TKey, TValue)

    Public Sub New()
    End Sub

    Public Sub New(map As IMap(Of TKey, TValue))
    End Sub

    Public Sub New(map As IMap(Of TKey, TValue), comparer As IEqualityComparer(Of TKey))
    End Sub

    Public Sub New(comparer As IEqualityComparer(Of TKey))
    End Sub

    Public Sub New(capacity As Integer)
    End Sub

    Public Sub New(capacity As Integer, comparer As IEqualityComparer(Of TKey))
    End Sub

    Public ReadOnly Property Comparer As IEqualityComparer(Of TKey)
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Public ReadOnly Property Count As Integer Implements ICollection(Of KeyValuePair(Of TKey, TValue)).Count, IReadOnlyCollection(Of KeyValuePair(Of TKey, TValue)).Count
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Private ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of KeyValuePair(Of TKey, TValue)).IsReadOnly
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Default Public Property Item(key As TKey) As TValue Implements IMap(Of TKey, TValue).Item, IReadOnlyMap(Of TKey, TValue).Item
        Get
            Throw New NotImplementedException
        End Get
        Set(value As TValue)
            Throw New NotImplementedException
        End Set
    End Property

    Public ReadOnly Property Keys As KeyCollection
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Private ReadOnly Property IMap_Keys As ICollection(Of TKey) Implements IMap(Of TKey, TValue).Keys
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Private ReadOnly Property IReadOnlyMap_Keys As IEnumerable(Of TKey) Implements IReadOnlyMap(Of TKey, TValue).Keys
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Public ReadOnly Property Values As ValueCollection
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Private ReadOnly Property IMap_Values As ICollection(Of TValue) Implements IMap(Of TKey, TValue).Values
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Private ReadOnly Property IReadOnlyMap_Values As IEnumerable(Of TValue) Implements IReadOnlyMap(Of TKey, TValue).Values
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Private Sub Add(item As KeyValuePair(Of TKey, TValue)) Implements ICollection(Of KeyValuePair(Of TKey, TValue)).Add
        Throw New NotImplementedException
    End Sub

    Public Sub Add(key As TKey, value As TValue) Implements IMap(Of TKey, TValue).Add
        Throw New NotImplementedException
    End Sub

    Public Sub Clear() Implements ICollection(Of KeyValuePair(Of TKey, TValue)).Clear
        Throw New NotImplementedException
    End Sub

    Private Sub CopyTo(array() As KeyValuePair(Of TKey, TValue), arrayIndex As Integer) Implements ICollection(Of KeyValuePair(Of TKey, TValue)).CopyTo
        Throw New NotImplementedException
    End Sub

    Private Function Contains(item As KeyValuePair(Of TKey, TValue)) As Boolean Implements ICollection(Of KeyValuePair(Of TKey, TValue)).Contains
        Throw New NotImplementedException
    End Function

    Public Function ContainsKey(key As TKey) As Boolean Implements IMap(Of TKey, TValue).ContainsKey, IReadOnlyMap(Of TKey, TValue).ContainsKey
        Throw New NotImplementedException
    End Function

    Public Function ContainsValue(value As TValue) As Boolean
        Throw New NotImplementedException
    End Function

    Public Function GetEnumerator() As Enumerator
        Throw New NotImplementedException
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Throw New NotImplementedException
    End Function

    Private Function IEnumerableOfT_GetEnumerator() As IEnumerator(Of KeyValuePair(Of TKey, TValue)) Implements IEnumerable(Of KeyValuePair(Of TKey, TValue)).GetEnumerator
        Throw New NotImplementedException
    End Function

    Private Function Remove(item As KeyValuePair(Of TKey, TValue)) As Boolean Implements ICollection(Of KeyValuePair(Of TKey, TValue)).Remove
        Throw New NotImplementedException
    End Function

    Public Function Remove(key As TKey) As Boolean Implements IMap(Of TKey, TValue).Remove
        Throw New NotImplementedException
    End Function

    Public Function TryGetValue(key As TKey, ByRef value As TValue) As Boolean Implements IMap(Of TKey, TValue).TryGetValue, IReadOnlyMap(Of TKey, TValue).TryGetValue
        Throw New NotImplementedException
    End Function

    Public Structure Enumerator
    End Structure

    Public NotInheritable Class KeyCollection
    End Class

    Public NotInheritable Class ValueCollection
    End Class
End Class