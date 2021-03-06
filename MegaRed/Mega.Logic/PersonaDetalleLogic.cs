using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class PersonaDetalleLogic
    {

        #region data Members

        PersonaDetalleDao _dataObject = null;

        #endregion

        #region Constructor

        public PersonaDetalleLogic()
        {
            _dataObject = new PersonaDetalleDao();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new PersonaDetalle
        /// </summary>
        /// <param name="businessObject">PersonaDetalle object</param>
        /// <returns>true for successfully saved</returns>
        public bool Insert(ref PersonaDetalleBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(ref objecBdo, ref message);

        }

        /// <summary>
        /// Update existing PersonaDetalle
        /// </summary>
        /// <param name="businessObject">PersonaDetalle object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ref PersonaDetalleBdo objecBdo, ref string message)
        {
            if (!objecBdo.IsValid)
            {
                throw new InvalidBusinessObjectException(objecBdo.BrokenRulesList.ToString());
            }


            return _dataObject.Update(ref objecBdo, ref message);
        }

        /// <summary>
        /// get PersonaDetalle by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public PersonaDetalleBdo GetById(int id)
        {
            return _dataObject.GetById(id); 
        }

        /// <summary>
        /// get list of all PersonaDetalles
        /// </summary>
        /// <returns>list</returns>
        public List<PersonaDetalleBdo> GetAll()
        {
            return _dataObject.GetAll(); 
        }

        /// <summary>
        /// get list of PersonaDetalle by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        public List<PersonaDetalleBdo> GetAllBy(PersonaDetalleBdo.PersonaDetalleFields fieldName, object value)
        {
            return _dataObject.GetAllBy(fieldName.ToString(), value);  
        }        

        #endregion

    }
}
