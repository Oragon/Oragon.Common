using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Oragon.Extensions
{
	///<summary>
	///Provides a set of extension methods dedicated to enumerables.
	///</summary>
	public static partial class OragonExtensions
	{
		#region Private Methods

		private static IEnumerable<T> UnionIterator<T>(HashSet<T> hashset, IEnumerable<T> seq)
		{
			Debug.Assert(hashset != null);
			Debug.Assert(seq != null);

			foreach (T t in hashset)
			{
				yield return t;
			}
			foreach (T t in seq)
			{
				if (hashset.Contains(t))
				{
					continue;
				}
				yield return t;
			}
		}

		#endregion Private Methods

		#region Private Classes

		private class CollectionReadOnlyWrapper<T> : IReadOnlyCollection<T>
		{
			#region Private Fields

			private readonly ICollection<T> m_Collection;

			#endregion Private Fields

			#region Internal Constructors

			internal CollectionReadOnlyWrapper(ICollection<T> collection)
			{
				Debug.Assert(collection != null);
				m_Collection = collection;
			}

			#endregion Internal Constructors

			#region Public Properties

			public int Count
			{
				get { return m_Collection.Count; }
			}

			#endregion Public Properties

			#region Public Methods

			public IEnumerator<T> GetEnumerator()
			{
				return m_Collection.GetEnumerator();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable)m_Collection).GetEnumerator();
			}

			#endregion Public Methods
		}

		private sealed class DicoLookup<TKey, T> : Dictionary<TKey, IEnumerable<T>>, ILookup<TKey, T>
		{
			#region Public Properties

			// HACK: 17Aug2012: these two are needed to avoid complex Code Contract warning!
			public new int Count { get { return base.Count; } }

			#endregion Public Properties

			#region Public Indexers

			public new IEnumerable<T> this[TKey key] { get { return base[key]; } set { base[key] = value; } }

			#endregion Public Indexers

			#region Public Methods

			public new IEnumerator<IGrouping<TKey, T>> GetEnumerator()
			{
				var dico = this as Dictionary<TKey, IEnumerable<T>>;
				foreach (var pair in dico)
				{
					yield return new Grouping(pair.Key, pair.Value);
				}
			}

			bool ILookup<TKey, T>.Contains(TKey key)
			{
				return this.ContainsKey(key);
			}

			#endregion Public Methods

			#region Private Classes

			private sealed class Grouping : IGrouping<TKey, T>
			{
				#region Private Fields

				private readonly TKey m_Key;

				private readonly IEnumerable<T> m_Seq;

				#endregion Private Fields

				#region Internal Constructors

				internal Grouping(TKey key, IEnumerable<T> seq)
				{
					Debug.Assert(seq != null);
					m_Key = key;
					m_Seq = seq;
				}

				#endregion Internal Constructors

				#region Public Properties

				public TKey Key { get { return m_Key; } }

				#endregion Public Properties

				#region Public Methods

				public IEnumerator<T> GetEnumerator()
				{
					return m_Seq.GetEnumerator();
				}

				IEnumerator IEnumerable.GetEnumerator()
				{
					return GetEnumerator();
				}

				#endregion Public Methods
			}

			#endregion Private Classes
		}

		private sealed class ListReadOnlyWrapper<T> : CollectionReadOnlyWrapper<T>, IReadOnlyList<T>
		{
			#region Private Fields

			private readonly IList<T> m_List;

			#endregion Private Fields

			#region Internal Constructors

			internal ListReadOnlyWrapper(IList<T> list)
				: base(list)
			{
				Debug.Assert(list != null);
				m_List = list;
			}

			#endregion Internal Constructors

			#region Public Indexers

			public T this[int index]
			{
				get { return m_List[index]; }
			}

			#endregion Public Indexers
		}

		#endregion Private Classes
	}
}