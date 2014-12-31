Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Public Class HashMap(Of TKey, TValue)
    Implements IHashMap(Of TKey, TValue), IReadOnlyHashMap(Of TKey, TValue)

#Region "Constructors"
    Public Sub New()
    End Sub

    Public Sub New(comparer As IEqualityComparer(Of TKey))
    End Sub

    Public Sub New(hashMap As IHashMap(Of TKey, TValue))
    End Sub

    Public Sub New(hashMap As IHashMap(Of TKey, TValue), comparer As IEqualityComparer(Of TKey))
    End Sub

    Public Sub New(capacity As Integer)
    End Sub

    Public Sub New(capacity As Integer, comparer As IEqualityComparer(Of TKey))
    End Sub
#End Region

#Region "Properties"
    Public ReadOnly Property Comparer As IEqualityComparer(Of TKey)
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property Count As Integer Implements ICollection(Of KeyValuePair(Of TKey, TValue)).Count, IReadOnlyCollection(Of KeyValuePair(Of TKey, TValue)).Count
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of KeyValuePair(Of TKey, TValue)).IsReadOnly
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Default Public Property Item(key As TKey) As TValue Implements IHashMap(Of TKey, TValue).Item, IReadOnlyHashMap(Of TKey, TValue).Item
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As TValue)
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property Keys As KeyCollection
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private ReadOnly Property IHashMap_Keys As ICollection(Of TKey) Implements IHashMap(Of TKey, TValue).Keys
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private ReadOnly Property IReadOnlyHashMap_Keys As IEnumerable(Of TKey) Implements IReadOnlyHashMap(Of TKey, TValue).Keys
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property Values As ValueCollection
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private ReadOnly Property IHashMap_Values As ICollection(Of TValue) Implements IHashMap(Of TKey, TValue).Values
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private ReadOnly Property IReadOnlyHashMap_Values As IEnumerable(Of TValue) Implements IReadOnlyHashMap(Of TKey, TValue).Values
        Get
            Throw New NotImplementedException()
        End Get
    End Property
#End Region

#Region "Methods"
    Private Sub Add(item As KeyValuePair(Of TKey, TValue)) Implements ICollection(Of KeyValuePair(Of TKey, TValue)).Add
        Throw New NotImplementedException()
    End Sub

    Public Sub Add(key As TKey, value As TValue) Implements IHashMap(Of TKey, TValue).Add
        Throw New NotImplementedException()
    End Sub

    Public Sub Clear() Implements ICollection(Of KeyValuePair(Of TKey, TValue)).Clear
        Throw New NotImplementedException()
    End Sub

    Private Function Contains(item As KeyValuePair(Of TKey, TValue)) As Boolean Implements ICollection(Of KeyValuePair(Of TKey, TValue)).Contains
        Throw New NotImplementedException()
    End Function

    Public Function ContainsKey(key As TKey) As Boolean Implements IHashMap(Of TKey, TValue).ContainsKey, IReadOnlyHashMap(Of TKey, TValue).ContainsKey
        Throw New NotImplementedException()
    End Function

    Public Function ContainsValue(value As TValue) As Boolean
        Throw New NotImplementedException()
    End Function

    Private Sub CopyTo(array() As KeyValuePair(Of TKey, TValue), arrayIndex As Integer) Implements ICollection(Of KeyValuePair(Of TKey, TValue)).CopyTo
        Throw New NotImplementedException()
    End Sub

    Public Function GetEnumerator() As Enumerator
        Throw New NotImplementedException()
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Throw New NotImplementedException()
    End Function

    Private Function IEnumerableOfT_GetEnumerator() As IEnumerator(Of KeyValuePair(Of TKey, TValue)) Implements IEnumerable(Of KeyValuePair(Of TKey, TValue)).GetEnumerator
        Throw New NotImplementedException()
    End Function

    Private Function Remove(item As KeyValuePair(Of TKey, TValue)) As Boolean Implements ICollection(Of KeyValuePair(Of TKey, TValue)).Remove
        Throw New NotImplementedException()
    End Function

    Public Function Remove(key As TKey) As Boolean Implements IHashMap(Of TKey, TValue).Remove
        Throw New NotImplementedException()
    End Function

    Public Function TryGetValue(key As TKey, <Out> ByRef value As TValue) As Boolean Implements IHashMap(Of TKey, TValue).TryGetValue, IReadOnlyHashMap(Of TKey, TValue).TryGetValue
        Throw New NotImplementedException()
    End Function
#End Region

    Public Structure Enumerator
        Implements IEnumerator(Of KeyValuePair(Of TKey, TValue))

#Region "Properties"
        Public ReadOnly Property Current As KeyValuePair(Of TKey, TValue) Implements IEnumerator(Of KeyValuePair(Of TKey, TValue)).Current
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Private ReadOnly Property IEnumerator_Current As Object Implements IEnumerator.Current
            Get
                Throw New NotImplementedException()
            End Get
        End Property
#End Region

#Region "Methods"
        Public Sub Dispose() Implements IDisposable.Dispose
            Throw New NotImplementedException()
        End Sub

        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            Throw New NotImplementedException()
        End Function

        Private Sub Reset() Implements IEnumerator.Reset
            Throw New NotImplementedException()
        End Sub
#End Region
    End Structure

    Public NotInheritable Class KeyCollection
        Implements ICollection(Of TKey)

        Public Sub New(hashMap As HashMap(Of TKey, TValue))
        End Sub

#Region "Properties"
        Public ReadOnly Property Count As Integer Implements ICollection(Of TKey).Count
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Private ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of TKey).IsReadOnly
            Get
                Throw New NotImplementedException()
            End Get
        End Property
#End Region

#Region "Methods"
        Private Sub Add(item As TKey) Implements ICollection(Of TKey).Add
            Throw New NotImplementedException()
        End Sub

        Private Sub Clear() Implements ICollection(Of TKey).Clear
            Throw New NotImplementedException()
        End Sub

        Private Function Contains(item As TKey) As Boolean Implements ICollection(Of TKey).Contains
            Throw New NotImplementedException()
        End Function

        Public Sub CopyTo(array() As TKey, arrayIndex As Integer) Implements ICollection(Of TKey).CopyTo
            Throw New NotImplementedException()
        End Sub

        Public Function GetEnumerator() As Enumerator
            Throw New NotImplementedException()
        End Function

        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Throw New NotImplementedException()
        End Function

        Private Function IEnumerableOfT_GetEnumerator() As IEnumerator(Of TKey) Implements IEnumerable(Of TKey).GetEnumerator
            Throw New NotImplementedException()
        End Function

        Private Function Remove(item As TKey) As Boolean Implements ICollection(Of TKey).Remove
            Throw New NotImplementedException()
        End Function
#End Region

        Public Structure Enumerator
            Implements IEnumerator(Of TKey)

#Region "Properties"
            Public ReadOnly Property Current As TKey Implements IEnumerator(Of TKey).Current
                Get
                    Throw New NotImplementedException()
                End Get
            End Property

            Private ReadOnly Property IEnumerator_Current As Object Implements IEnumerator.Current
                Get
                    Throw New NotImplementedException()
                End Get
            End Property
#End Region

#Region "Methods"
            Public Sub Dispose() Implements IDisposable.Dispose
                Throw New NotImplementedException()
            End Sub

            Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
                Throw New NotImplementedException()
            End Function

            Private Sub Reset() Implements IEnumerator.Reset
                Throw New NotImplementedException()
            End Sub
#End Region
        End Structure
    End Class

    Public NotInheritable Class ValueCollection
    End Class
End Class