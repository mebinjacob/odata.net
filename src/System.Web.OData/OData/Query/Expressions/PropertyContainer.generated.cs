﻿using System.Collections.Generic;

namespace System.Web.OData.Query.Expressions
{
	internal abstract partial class PropertyContainer
	{
        // Entityframework requires that the two different type initializers for a given type in the same query have the same set of properties in the same order.
        // A $select=Prop1,Prop2,Prop3 where Prop1 and Prop2 are of the same type without this extra NamedPropertyWithNext type results in an select expression that looks like,
        //      c => new NamedProperty<int> { Name = "Prop1", Value = c.Prop1, Next0 = new NamedProperty<int> { Name = "Prop2", Value = c.Prop2 }, Next2 = new NamedProperty<int> { Name = "Prop3", Value = c.Prop3 } };
        // Entityframework cannot translate this expression as the first NamedProperty<int> initialization has Next and the second one doesn't. Also, Entityframework cannot 
        // create null's of NamedProperty<T>. So, you cannot generate an expression like new NamedProperty<int> { Next = null }. The exception that EF throws looks like this,
        // "The type 'NamedProperty`1[SystemInt32...]' appears in two structurally incompatible initializations within a single LINQ to Entities query. 
        // A type can be initialized in two places in the same query, but only if the same properties are set in both places and those properties are set in the same order."

			private class SingleExpandedPropertyWithNext0<T> : SingleExpandedProperty<T>
        {
            public PropertyContainer Next0 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next0.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext1<T> : SingleExpandedPropertyWithNext0<T>
        {
            public PropertyContainer Next1 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next1.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext2<T> : SingleExpandedPropertyWithNext1<T>
        {
            public PropertyContainer Next2 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next2.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext3<T> : SingleExpandedPropertyWithNext2<T>
        {
            public PropertyContainer Next3 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next3.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext4<T> : SingleExpandedPropertyWithNext3<T>
        {
            public PropertyContainer Next4 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next4.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext5<T> : SingleExpandedPropertyWithNext4<T>
        {
            public PropertyContainer Next5 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next5.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext6<T> : SingleExpandedPropertyWithNext5<T>
        {
            public PropertyContainer Next6 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next6.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext7<T> : SingleExpandedPropertyWithNext6<T>
        {
            public PropertyContainer Next7 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next7.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext8<T> : SingleExpandedPropertyWithNext7<T>
        {
            public PropertyContainer Next8 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next8.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext9<T> : SingleExpandedPropertyWithNext8<T>
        {
            public PropertyContainer Next9 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next9.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext10<T> : SingleExpandedPropertyWithNext9<T>
        {
            public PropertyContainer Next10 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next10.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext11<T> : SingleExpandedPropertyWithNext10<T>
        {
            public PropertyContainer Next11 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next11.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext12<T> : SingleExpandedPropertyWithNext11<T>
        {
            public PropertyContainer Next12 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next12.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext13<T> : SingleExpandedPropertyWithNext12<T>
        {
            public PropertyContainer Next13 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next13.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext14<T> : SingleExpandedPropertyWithNext13<T>
        {
            public PropertyContainer Next14 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next14.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext15<T> : SingleExpandedPropertyWithNext14<T>
        {
            public PropertyContainer Next15 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next15.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext16<T> : SingleExpandedPropertyWithNext15<T>
        {
            public PropertyContainer Next16 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next16.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext17<T> : SingleExpandedPropertyWithNext16<T>
        {
            public PropertyContainer Next17 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next17.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext18<T> : SingleExpandedPropertyWithNext17<T>
        {
            public PropertyContainer Next18 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next18.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext19<T> : SingleExpandedPropertyWithNext18<T>
        {
            public PropertyContainer Next19 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next19.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext20<T> : SingleExpandedPropertyWithNext19<T>
        {
            public PropertyContainer Next20 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next20.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext21<T> : SingleExpandedPropertyWithNext20<T>
        {
            public PropertyContainer Next21 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next21.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext22<T> : SingleExpandedPropertyWithNext21<T>
        {
            public PropertyContainer Next22 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next22.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext23<T> : SingleExpandedPropertyWithNext22<T>
        {
            public PropertyContainer Next23 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next23.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext24<T> : SingleExpandedPropertyWithNext23<T>
        {
            public PropertyContainer Next24 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next24.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext25<T> : SingleExpandedPropertyWithNext24<T>
        {
            public PropertyContainer Next25 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next25.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext26<T> : SingleExpandedPropertyWithNext25<T>
        {
            public PropertyContainer Next26 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next26.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext27<T> : SingleExpandedPropertyWithNext26<T>
        {
            public PropertyContainer Next27 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next27.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext28<T> : SingleExpandedPropertyWithNext27<T>
        {
            public PropertyContainer Next28 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next28.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext29<T> : SingleExpandedPropertyWithNext28<T>
        {
            public PropertyContainer Next29 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next29.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext30<T> : SingleExpandedPropertyWithNext29<T>
        {
            public PropertyContainer Next30 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next30.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class SingleExpandedPropertyWithNext31<T> : SingleExpandedPropertyWithNext30<T>
        {
            public PropertyContainer Next31 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next31.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
		private static List<Type> SingleExpandedPropertyTypes = new List<Type> {
		typeof(SingleExpandedProperty<>),
				typeof(SingleExpandedPropertyWithNext0<>),
					typeof(SingleExpandedPropertyWithNext1<>),
					typeof(SingleExpandedPropertyWithNext2<>),
					typeof(SingleExpandedPropertyWithNext3<>),
					typeof(SingleExpandedPropertyWithNext4<>),
					typeof(SingleExpandedPropertyWithNext5<>),
					typeof(SingleExpandedPropertyWithNext6<>),
					typeof(SingleExpandedPropertyWithNext7<>),
					typeof(SingleExpandedPropertyWithNext8<>),
					typeof(SingleExpandedPropertyWithNext9<>),
					typeof(SingleExpandedPropertyWithNext10<>),
					typeof(SingleExpandedPropertyWithNext11<>),
					typeof(SingleExpandedPropertyWithNext12<>),
					typeof(SingleExpandedPropertyWithNext13<>),
					typeof(SingleExpandedPropertyWithNext14<>),
					typeof(SingleExpandedPropertyWithNext15<>),
					typeof(SingleExpandedPropertyWithNext16<>),
					typeof(SingleExpandedPropertyWithNext17<>),
					typeof(SingleExpandedPropertyWithNext18<>),
					typeof(SingleExpandedPropertyWithNext19<>),
					typeof(SingleExpandedPropertyWithNext20<>),
					typeof(SingleExpandedPropertyWithNext21<>),
					typeof(SingleExpandedPropertyWithNext22<>),
					typeof(SingleExpandedPropertyWithNext23<>),
					typeof(SingleExpandedPropertyWithNext24<>),
					typeof(SingleExpandedPropertyWithNext25<>),
					typeof(SingleExpandedPropertyWithNext26<>),
					typeof(SingleExpandedPropertyWithNext27<>),
					typeof(SingleExpandedPropertyWithNext28<>),
					typeof(SingleExpandedPropertyWithNext29<>),
					typeof(SingleExpandedPropertyWithNext30<>),
					typeof(SingleExpandedPropertyWithNext31<>),
			};
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			private class CollectionExpandedPropertyWithNext0<T> : CollectionExpandedProperty<T>
        {
            public PropertyContainer Next0 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next0.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext1<T> : CollectionExpandedPropertyWithNext0<T>
        {
            public PropertyContainer Next1 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next1.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext2<T> : CollectionExpandedPropertyWithNext1<T>
        {
            public PropertyContainer Next2 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next2.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext3<T> : CollectionExpandedPropertyWithNext2<T>
        {
            public PropertyContainer Next3 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next3.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext4<T> : CollectionExpandedPropertyWithNext3<T>
        {
            public PropertyContainer Next4 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next4.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext5<T> : CollectionExpandedPropertyWithNext4<T>
        {
            public PropertyContainer Next5 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next5.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext6<T> : CollectionExpandedPropertyWithNext5<T>
        {
            public PropertyContainer Next6 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next6.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext7<T> : CollectionExpandedPropertyWithNext6<T>
        {
            public PropertyContainer Next7 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next7.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext8<T> : CollectionExpandedPropertyWithNext7<T>
        {
            public PropertyContainer Next8 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next8.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext9<T> : CollectionExpandedPropertyWithNext8<T>
        {
            public PropertyContainer Next9 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next9.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext10<T> : CollectionExpandedPropertyWithNext9<T>
        {
            public PropertyContainer Next10 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next10.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext11<T> : CollectionExpandedPropertyWithNext10<T>
        {
            public PropertyContainer Next11 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next11.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext12<T> : CollectionExpandedPropertyWithNext11<T>
        {
            public PropertyContainer Next12 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next12.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext13<T> : CollectionExpandedPropertyWithNext12<T>
        {
            public PropertyContainer Next13 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next13.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext14<T> : CollectionExpandedPropertyWithNext13<T>
        {
            public PropertyContainer Next14 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next14.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext15<T> : CollectionExpandedPropertyWithNext14<T>
        {
            public PropertyContainer Next15 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next15.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext16<T> : CollectionExpandedPropertyWithNext15<T>
        {
            public PropertyContainer Next16 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next16.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext17<T> : CollectionExpandedPropertyWithNext16<T>
        {
            public PropertyContainer Next17 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next17.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext18<T> : CollectionExpandedPropertyWithNext17<T>
        {
            public PropertyContainer Next18 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next18.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext19<T> : CollectionExpandedPropertyWithNext18<T>
        {
            public PropertyContainer Next19 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next19.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext20<T> : CollectionExpandedPropertyWithNext19<T>
        {
            public PropertyContainer Next20 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next20.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext21<T> : CollectionExpandedPropertyWithNext20<T>
        {
            public PropertyContainer Next21 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next21.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext22<T> : CollectionExpandedPropertyWithNext21<T>
        {
            public PropertyContainer Next22 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next22.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext23<T> : CollectionExpandedPropertyWithNext22<T>
        {
            public PropertyContainer Next23 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next23.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext24<T> : CollectionExpandedPropertyWithNext23<T>
        {
            public PropertyContainer Next24 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next24.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext25<T> : CollectionExpandedPropertyWithNext24<T>
        {
            public PropertyContainer Next25 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next25.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext26<T> : CollectionExpandedPropertyWithNext25<T>
        {
            public PropertyContainer Next26 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next26.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext27<T> : CollectionExpandedPropertyWithNext26<T>
        {
            public PropertyContainer Next27 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next27.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext28<T> : CollectionExpandedPropertyWithNext27<T>
        {
            public PropertyContainer Next28 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next28.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext29<T> : CollectionExpandedPropertyWithNext28<T>
        {
            public PropertyContainer Next29 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next29.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext30<T> : CollectionExpandedPropertyWithNext29<T>
        {
            public PropertyContainer Next30 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next30.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class CollectionExpandedPropertyWithNext31<T> : CollectionExpandedPropertyWithNext30<T>
        {
            public PropertyContainer Next31 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next31.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
		private static List<Type> CollectionExpandedPropertyTypes = new List<Type> {
		typeof(CollectionExpandedProperty<>),
				typeof(CollectionExpandedPropertyWithNext0<>),
					typeof(CollectionExpandedPropertyWithNext1<>),
					typeof(CollectionExpandedPropertyWithNext2<>),
					typeof(CollectionExpandedPropertyWithNext3<>),
					typeof(CollectionExpandedPropertyWithNext4<>),
					typeof(CollectionExpandedPropertyWithNext5<>),
					typeof(CollectionExpandedPropertyWithNext6<>),
					typeof(CollectionExpandedPropertyWithNext7<>),
					typeof(CollectionExpandedPropertyWithNext8<>),
					typeof(CollectionExpandedPropertyWithNext9<>),
					typeof(CollectionExpandedPropertyWithNext10<>),
					typeof(CollectionExpandedPropertyWithNext11<>),
					typeof(CollectionExpandedPropertyWithNext12<>),
					typeof(CollectionExpandedPropertyWithNext13<>),
					typeof(CollectionExpandedPropertyWithNext14<>),
					typeof(CollectionExpandedPropertyWithNext15<>),
					typeof(CollectionExpandedPropertyWithNext16<>),
					typeof(CollectionExpandedPropertyWithNext17<>),
					typeof(CollectionExpandedPropertyWithNext18<>),
					typeof(CollectionExpandedPropertyWithNext19<>),
					typeof(CollectionExpandedPropertyWithNext20<>),
					typeof(CollectionExpandedPropertyWithNext21<>),
					typeof(CollectionExpandedPropertyWithNext22<>),
					typeof(CollectionExpandedPropertyWithNext23<>),
					typeof(CollectionExpandedPropertyWithNext24<>),
					typeof(CollectionExpandedPropertyWithNext25<>),
					typeof(CollectionExpandedPropertyWithNext26<>),
					typeof(CollectionExpandedPropertyWithNext27<>),
					typeof(CollectionExpandedPropertyWithNext28<>),
					typeof(CollectionExpandedPropertyWithNext29<>),
					typeof(CollectionExpandedPropertyWithNext30<>),
					typeof(CollectionExpandedPropertyWithNext31<>),
			};
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			private class AutoSelectedNamedPropertyWithNext0<T> : AutoSelectedNamedProperty<T>
        {
            public PropertyContainer Next0 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next0.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext1<T> : AutoSelectedNamedPropertyWithNext0<T>
        {
            public PropertyContainer Next1 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next1.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext2<T> : AutoSelectedNamedPropertyWithNext1<T>
        {
            public PropertyContainer Next2 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next2.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext3<T> : AutoSelectedNamedPropertyWithNext2<T>
        {
            public PropertyContainer Next3 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next3.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext4<T> : AutoSelectedNamedPropertyWithNext3<T>
        {
            public PropertyContainer Next4 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next4.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext5<T> : AutoSelectedNamedPropertyWithNext4<T>
        {
            public PropertyContainer Next5 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next5.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext6<T> : AutoSelectedNamedPropertyWithNext5<T>
        {
            public PropertyContainer Next6 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next6.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext7<T> : AutoSelectedNamedPropertyWithNext6<T>
        {
            public PropertyContainer Next7 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next7.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext8<T> : AutoSelectedNamedPropertyWithNext7<T>
        {
            public PropertyContainer Next8 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next8.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext9<T> : AutoSelectedNamedPropertyWithNext8<T>
        {
            public PropertyContainer Next9 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next9.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext10<T> : AutoSelectedNamedPropertyWithNext9<T>
        {
            public PropertyContainer Next10 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next10.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext11<T> : AutoSelectedNamedPropertyWithNext10<T>
        {
            public PropertyContainer Next11 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next11.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext12<T> : AutoSelectedNamedPropertyWithNext11<T>
        {
            public PropertyContainer Next12 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next12.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext13<T> : AutoSelectedNamedPropertyWithNext12<T>
        {
            public PropertyContainer Next13 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next13.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext14<T> : AutoSelectedNamedPropertyWithNext13<T>
        {
            public PropertyContainer Next14 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next14.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext15<T> : AutoSelectedNamedPropertyWithNext14<T>
        {
            public PropertyContainer Next15 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next15.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext16<T> : AutoSelectedNamedPropertyWithNext15<T>
        {
            public PropertyContainer Next16 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next16.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext17<T> : AutoSelectedNamedPropertyWithNext16<T>
        {
            public PropertyContainer Next17 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next17.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext18<T> : AutoSelectedNamedPropertyWithNext17<T>
        {
            public PropertyContainer Next18 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next18.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext19<T> : AutoSelectedNamedPropertyWithNext18<T>
        {
            public PropertyContainer Next19 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next19.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext20<T> : AutoSelectedNamedPropertyWithNext19<T>
        {
            public PropertyContainer Next20 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next20.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext21<T> : AutoSelectedNamedPropertyWithNext20<T>
        {
            public PropertyContainer Next21 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next21.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext22<T> : AutoSelectedNamedPropertyWithNext21<T>
        {
            public PropertyContainer Next22 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next22.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext23<T> : AutoSelectedNamedPropertyWithNext22<T>
        {
            public PropertyContainer Next23 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next23.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext24<T> : AutoSelectedNamedPropertyWithNext23<T>
        {
            public PropertyContainer Next24 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next24.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext25<T> : AutoSelectedNamedPropertyWithNext24<T>
        {
            public PropertyContainer Next25 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next25.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext26<T> : AutoSelectedNamedPropertyWithNext25<T>
        {
            public PropertyContainer Next26 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next26.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext27<T> : AutoSelectedNamedPropertyWithNext26<T>
        {
            public PropertyContainer Next27 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next27.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext28<T> : AutoSelectedNamedPropertyWithNext27<T>
        {
            public PropertyContainer Next28 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next28.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext29<T> : AutoSelectedNamedPropertyWithNext28<T>
        {
            public PropertyContainer Next29 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next29.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext30<T> : AutoSelectedNamedPropertyWithNext29<T>
        {
            public PropertyContainer Next30 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next30.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class AutoSelectedNamedPropertyWithNext31<T> : AutoSelectedNamedPropertyWithNext30<T>
        {
            public PropertyContainer Next31 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next31.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
		private static List<Type> AutoSelectedNamedPropertyTypes = new List<Type> {
		typeof(AutoSelectedNamedProperty<>),
				typeof(AutoSelectedNamedPropertyWithNext0<>),
					typeof(AutoSelectedNamedPropertyWithNext1<>),
					typeof(AutoSelectedNamedPropertyWithNext2<>),
					typeof(AutoSelectedNamedPropertyWithNext3<>),
					typeof(AutoSelectedNamedPropertyWithNext4<>),
					typeof(AutoSelectedNamedPropertyWithNext5<>),
					typeof(AutoSelectedNamedPropertyWithNext6<>),
					typeof(AutoSelectedNamedPropertyWithNext7<>),
					typeof(AutoSelectedNamedPropertyWithNext8<>),
					typeof(AutoSelectedNamedPropertyWithNext9<>),
					typeof(AutoSelectedNamedPropertyWithNext10<>),
					typeof(AutoSelectedNamedPropertyWithNext11<>),
					typeof(AutoSelectedNamedPropertyWithNext12<>),
					typeof(AutoSelectedNamedPropertyWithNext13<>),
					typeof(AutoSelectedNamedPropertyWithNext14<>),
					typeof(AutoSelectedNamedPropertyWithNext15<>),
					typeof(AutoSelectedNamedPropertyWithNext16<>),
					typeof(AutoSelectedNamedPropertyWithNext17<>),
					typeof(AutoSelectedNamedPropertyWithNext18<>),
					typeof(AutoSelectedNamedPropertyWithNext19<>),
					typeof(AutoSelectedNamedPropertyWithNext20<>),
					typeof(AutoSelectedNamedPropertyWithNext21<>),
					typeof(AutoSelectedNamedPropertyWithNext22<>),
					typeof(AutoSelectedNamedPropertyWithNext23<>),
					typeof(AutoSelectedNamedPropertyWithNext24<>),
					typeof(AutoSelectedNamedPropertyWithNext25<>),
					typeof(AutoSelectedNamedPropertyWithNext26<>),
					typeof(AutoSelectedNamedPropertyWithNext27<>),
					typeof(AutoSelectedNamedPropertyWithNext28<>),
					typeof(AutoSelectedNamedPropertyWithNext29<>),
					typeof(AutoSelectedNamedPropertyWithNext30<>),
					typeof(AutoSelectedNamedPropertyWithNext31<>),
			};
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			private class NamedPropertyWithNext0<T> : NamedProperty<T>
        {
            public PropertyContainer Next0 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next0.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext1<T> : NamedPropertyWithNext0<T>
        {
            public PropertyContainer Next1 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next1.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext2<T> : NamedPropertyWithNext1<T>
        {
            public PropertyContainer Next2 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next2.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext3<T> : NamedPropertyWithNext2<T>
        {
            public PropertyContainer Next3 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next3.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext4<T> : NamedPropertyWithNext3<T>
        {
            public PropertyContainer Next4 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next4.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext5<T> : NamedPropertyWithNext4<T>
        {
            public PropertyContainer Next5 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next5.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext6<T> : NamedPropertyWithNext5<T>
        {
            public PropertyContainer Next6 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next6.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext7<T> : NamedPropertyWithNext6<T>
        {
            public PropertyContainer Next7 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next7.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext8<T> : NamedPropertyWithNext7<T>
        {
            public PropertyContainer Next8 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next8.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext9<T> : NamedPropertyWithNext8<T>
        {
            public PropertyContainer Next9 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next9.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext10<T> : NamedPropertyWithNext9<T>
        {
            public PropertyContainer Next10 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next10.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext11<T> : NamedPropertyWithNext10<T>
        {
            public PropertyContainer Next11 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next11.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext12<T> : NamedPropertyWithNext11<T>
        {
            public PropertyContainer Next12 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next12.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext13<T> : NamedPropertyWithNext12<T>
        {
            public PropertyContainer Next13 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next13.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext14<T> : NamedPropertyWithNext13<T>
        {
            public PropertyContainer Next14 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next14.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext15<T> : NamedPropertyWithNext14<T>
        {
            public PropertyContainer Next15 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next15.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext16<T> : NamedPropertyWithNext15<T>
        {
            public PropertyContainer Next16 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next16.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext17<T> : NamedPropertyWithNext16<T>
        {
            public PropertyContainer Next17 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next17.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext18<T> : NamedPropertyWithNext17<T>
        {
            public PropertyContainer Next18 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next18.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext19<T> : NamedPropertyWithNext18<T>
        {
            public PropertyContainer Next19 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next19.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext20<T> : NamedPropertyWithNext19<T>
        {
            public PropertyContainer Next20 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next20.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext21<T> : NamedPropertyWithNext20<T>
        {
            public PropertyContainer Next21 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next21.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext22<T> : NamedPropertyWithNext21<T>
        {
            public PropertyContainer Next22 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next22.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext23<T> : NamedPropertyWithNext22<T>
        {
            public PropertyContainer Next23 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next23.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext24<T> : NamedPropertyWithNext23<T>
        {
            public PropertyContainer Next24 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next24.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext25<T> : NamedPropertyWithNext24<T>
        {
            public PropertyContainer Next25 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next25.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext26<T> : NamedPropertyWithNext25<T>
        {
            public PropertyContainer Next26 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next26.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext27<T> : NamedPropertyWithNext26<T>
        {
            public PropertyContainer Next27 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next27.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext28<T> : NamedPropertyWithNext27<T>
        {
            public PropertyContainer Next28 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next28.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext29<T> : NamedPropertyWithNext28<T>
        {
            public PropertyContainer Next29 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next29.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext30<T> : NamedPropertyWithNext29<T>
        {
            public PropertyContainer Next30 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next30.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
			private class NamedPropertyWithNext31<T> : NamedPropertyWithNext30<T>
        {
            public PropertyContainer Next31 { get; set; }

            public override void ToDictionaryCore(Dictionary<string, object> dictionary, IPropertyMapper propertyMapper,
                bool includeAutoSelected)
            {
                base.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
                Next31.ToDictionaryCore(dictionary, propertyMapper, includeAutoSelected);
            }
        }
		private static List<Type> NamedPropertyTypes = new List<Type> {
		typeof(NamedProperty<>),
				typeof(NamedPropertyWithNext0<>),
					typeof(NamedPropertyWithNext1<>),
					typeof(NamedPropertyWithNext2<>),
					typeof(NamedPropertyWithNext3<>),
					typeof(NamedPropertyWithNext4<>),
					typeof(NamedPropertyWithNext5<>),
					typeof(NamedPropertyWithNext6<>),
					typeof(NamedPropertyWithNext7<>),
					typeof(NamedPropertyWithNext8<>),
					typeof(NamedPropertyWithNext9<>),
					typeof(NamedPropertyWithNext10<>),
					typeof(NamedPropertyWithNext11<>),
					typeof(NamedPropertyWithNext12<>),
					typeof(NamedPropertyWithNext13<>),
					typeof(NamedPropertyWithNext14<>),
					typeof(NamedPropertyWithNext15<>),
					typeof(NamedPropertyWithNext16<>),
					typeof(NamedPropertyWithNext17<>),
					typeof(NamedPropertyWithNext18<>),
					typeof(NamedPropertyWithNext19<>),
					typeof(NamedPropertyWithNext20<>),
					typeof(NamedPropertyWithNext21<>),
					typeof(NamedPropertyWithNext22<>),
					typeof(NamedPropertyWithNext23<>),
					typeof(NamedPropertyWithNext24<>),
					typeof(NamedPropertyWithNext25<>),
					typeof(NamedPropertyWithNext26<>),
					typeof(NamedPropertyWithNext27<>),
					typeof(NamedPropertyWithNext28<>),
					typeof(NamedPropertyWithNext29<>),
					typeof(NamedPropertyWithNext30<>),
					typeof(NamedPropertyWithNext31<>),
			};
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
	
	}
}