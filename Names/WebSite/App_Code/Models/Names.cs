using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using TestCompany.Data;

namespace TestCompany.Models
{
	public partial class NamesModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iD;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _names;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _type;
        
        public NamesModel()
        {
        }
        
        public NamesModel(BusinessRules r) : 
                base(r)
        {
        }
        
        public int? ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
                UpdateFieldValue("ID", value);
            }
        }
        
        public string Names_
        {
            get
            {
                return _names;
            }
            set
            {
                _names = value;
                UpdateFieldValue("Names_", value);
            }
        }
        
        public int? Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                UpdateFieldValue("Type", value);
            }
        }
    }
}
