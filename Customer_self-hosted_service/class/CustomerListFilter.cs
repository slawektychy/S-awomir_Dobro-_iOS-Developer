/*
 *      Sławomir_Dobroś_iOS Developer
 *      2016-08-10 
 */

namespace Customers_self_hosted_service
{
    /// <summary>
    /// Class contains informations about customer list filtering 
    /// </summary>
    public class CustomerListFilter
    {
      
        #region Private properties

        bool isEnabled;
        FilterConditions condition;
        FilterFieldsNames fieldName;
        string fieldValue;

        #endregion

        #region Public properties
        /// <summary>
        /// It stores information about filter field name
        /// </summary>
        public FilterFieldsNames FieldName
        {
            get
            {
                return fieldName;
            }

            set
            {
                fieldName = value;
            }
        }

        /// <summary>
        /// It stores information about filter field value
        /// </summary>
        public string FieldValue
        {
            get
            {
                return fieldValue;
            }

            set
            {
                fieldValue = value;
            }
        }

        /// <summary>
        /// It stores information about whether the filter is active
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }

            set
            {
                isEnabled = value;
            }
        }

        /// <summary>
        /// It stores information about filter condition
        /// </summary>
        public FilterConditions Condition
        {
            get
            {
                return condition;
            }

            set
            {
                condition = value;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// The default constructor
        /// </summary>
        public CustomerListFilter()
        {
            condition = FilterConditions.CONTAINS;
            fieldName = FilterFieldsNames.NAME;
            fieldValue = " ";
        }

        #endregion

    }

    /// <summary>
    /// Enum with names of filter fields
    /// </summary>
    public enum FilterFieldsNames
    {
        NAME,SURNAME,PHONE,CITY,STREET,POSTCODE
    }

    /// <summary>
    /// Enum with names of filter conditions
    /// </summary>
    public enum FilterConditions
    {
        IS_EQUAL, CONTAINS
    }
}
