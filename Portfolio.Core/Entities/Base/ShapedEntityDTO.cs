using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Portfolio.Core.Entities.Base
{
    public class ShapedEntityDTO : DynamicObject, IXmlSerializable, IDictionary<string, object>
    {
        private readonly string _root = "ShapedEntityDTO";
        private readonly IDictionary<string, object> _expando = null;
        public ShapedEntityDTO() => _expando = new ExpandoObject();

        #region "IDictionary"
        public object this[string key] { get => _expando[key]; set => _expando[key] = value; }
        public ICollection<string> Keys { get => _expando.Keys; }
        public ICollection<object> Values { get => _expando.Values; }
        public int Count { get => _expando.Count; }
        public bool IsReadOnly { get => _expando.IsReadOnly; }
        public void Add(string key, object value) => _expando.Add(key, value);
        public void Add(KeyValuePair<string, object> item) => _expando.Add(item);
        public void Clear() => _expando.Clear();
        public bool Contains(KeyValuePair<string, object> item) => _expando.Contains(item);
        public bool ContainsKey(string key) => _expando.ContainsKey(key);
        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) => _expando.CopyTo(array, arrayIndex);
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => _expando.GetEnumerator();
        public bool Remove(string key) => _expando.Remove(key);
        public bool Remove(KeyValuePair<string, object> item) => _expando.Remove(item);
        public bool TryGetValue(string key, [MaybeNullWhen(false)] out object value) => _expando.TryGetValue(key, out value);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion

        #region "IXmlSerializable."
        public XmlSchema GetSchema() => throw new NotImplementedException();
        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement(_root);

            while (!reader.Name.Equals(_root))
            {
                string typeContent;
                Type underlyingType;
                var name = reader.Name;

                reader.MoveToAttribute("type");
                typeContent = reader.ReadContentAsString();
                underlyingType = Type.GetType(typeContent);
                reader.MoveToContent();
                _expando[name] = reader.ReadElementContentAs(underlyingType, null);
            }
        }
        public void WriteXml(XmlWriter writer)
        {
            foreach (var key in _expando.Keys)
            {
                var value = _expando[key];
                WriteLinksToXml(key, value, writer);
            }
        }
        private void WriteLinksToXml(string key, object value, XmlWriter writer)
        {
            writer.WriteStartElement(key); writer.WriteString(value.ToString()); writer.WriteEndElement();
        }
        #endregion
    }
}
