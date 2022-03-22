//using System;
//using System.Collections.Generic;
//using System.Text;
//using static just.For.practice.reflection;

//namespace just.For.practice
//{
//    public class PropertyMatcher<TParent, TChild> where TParent : class where TChild : class
//    {
//        public static void GenerateMatchedObject(TParent parent, TChild child)
//        {
//            var childProperties = child.GetType().GetProperties();
//            foreach (var childProperty in childProperties)
//            {
//                var attributesForProperty = childProperty.GetCustomAttributes(typeof(MatchParentAttribute), true);
//                var isOfTypeMatchParentAttribute = false;
//                MatchParentAttribute currentAttribute = null;
//                foreach (var attribute in attributesForProperty)
//                {   
//                    if(attribute.GetType()== typeof(MatchParentAttribute))
//                    {
//                        isOfTypeMatchParentAttribute = true;
//                        currentAttribute = (MatchParentAttribute)attribute;
//                        break;
//                    }
//                }
//                if(isOfTypeMatchParentAttribute)
//                {
//                    var parentPropeties = parent.GetType().GetProperties();
//                    object ParentPropertyValue = null;
//                    foreach(var parentProperty in parentPropeties)
//                    {
//                        if(parentProperty.Name== currentAttribute.ParentPropertyName)
//                        {
//                            if(parentProperty.PropertyType== childProperty.PropertyType)
//                            {
//                                ParentPropertyValue = parentProperty.GetValue(parent);
//                            }
//                        }
//                    }
//                    childProperty.SetValue(child, ParentPropertyValue);
//                }
//            }
//        }
//    }
//}
