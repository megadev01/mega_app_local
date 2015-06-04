using System;
using System.Collections.Generic;
using System.Text;
namespace Mega.Bdo
{
	public partial class MovimientoFondosBdo : BdoObjectBase
	{

		#region InnerClass
		public enum MovimientoFondosFields
		{
			NumeroDocumento,
			CodDocumento,
			MonedaId,
			Importe,
			OficinaIdProcedencia,
			OficinaIdDestino,
			CodigoPersona,
			BancoId,
			NumeroCuentaBanco,
			CodigoVoucher,
			NumeroOperacion,
			CajaAperturaId,
			FechaHoraAnulacion,
			Estado,
			UsuarioAnulacion,
			ConceptoId,
			TipoMovimiento,
			FechaHoraTransaccion,
			FechaHoraDescargo,
			FlagImpreso
		}
		#endregion

		#region Data Members

			int _numeroDocumento;
			string _codDocumento;
			int? _monedaId;
			decimal? _importe;
			string _oficinaIdProcedencia;
			string _oficinaIdDestino;
			string _codigoPersona;
			int? _bancoId;
			int? _numeroCuentaBanco;
			string _codigoVoucher;
			string _numeroOperacion;
			int? _cajaAperturaId;
			DateTime? _fechaHoraAnulacion;
			int? _estado;
			string _usuarioAnulacion;
			int? _conceptoId;
			int? _tipoMovimiento;
			DateTime? _fechaHoraTransaccion;
			DateTime? _fechaHoraDescargo;
			bool _flagImpreso;

		#endregion

		#region Properties

		public int  NumeroDocumento
		{
			 get { return _numeroDocumento; }
			 set
			 {
				 if (_numeroDocumento != value)
				 {
					_numeroDocumento = value;
					 PropertyHasChanged("NumeroDocumento");
				 }
			 }
		}

		public string  CodDocumento
		{
			 get { return _codDocumento; }
			 set
			 {
				 if (_codDocumento != value)
				 {
					_codDocumento = value;
					 PropertyHasChanged("CodDocumento");
				 }
			 }
		}

		public int?  MonedaId
		{
			 get { return _monedaId; }
			 set
			 {
				 if (_monedaId != value)
				 {
					_monedaId = value;
					 PropertyHasChanged("MonedaId");
				 }
			 }
		}

		public decimal?  Importe
		{
			 get { return _importe; }
			 set
			 {
				 if (_importe != value)
				 {
					_importe = value;
					 PropertyHasChanged("Importe");
				 }
			 }
		}

		public string  OficinaIdProcedencia
		{
			 get { return _oficinaIdProcedencia; }
			 set
			 {
				 if (_oficinaIdProcedencia != value)
				 {
					_oficinaIdProcedencia = value;
					 PropertyHasChanged("OficinaIdProcedencia");
				 }
			 }
		}

		public string  OficinaIdDestino
		{
			 get { return _oficinaIdDestino; }
			 set
			 {
				 if (_oficinaIdDestino != value)
				 {
					_oficinaIdDestino = value;
					 PropertyHasChanged("OficinaIdDestino");
				 }
			 }
		}

		public string  CodigoPersona
		{
			 get { return _codigoPersona; }
			 set
			 {
				 if (_codigoPersona != value)
				 {
					_codigoPersona = value;
					 PropertyHasChanged("CodigoPersona");
				 }
			 }
		}

		public int?  BancoId
		{
			 get { return _bancoId; }
			 set
			 {
				 if (_bancoId != value)
				 {
					_bancoId = value;
					 PropertyHasChanged("BancoId");
				 }
			 }
		}

		public int?  NumeroCuentaBanco
		{
			 get { return _numeroCuentaBanco; }
			 set
			 {
				 if (_numeroCuentaBanco != value)
				 {
					_numeroCuentaBanco = value;
					 PropertyHasChanged("NumeroCuentaBanco");
				 }
			 }
		}

		public string  CodigoVoucher
		{
			 get { return _codigoVoucher; }
			 set
			 {
				 if (_codigoVoucher != value)
				 {
					_codigoVoucher = value;
					 PropertyHasChanged("CodigoVoucher");
				 }
			 }
		}

		public string  NumeroOperacion
		{
			 get { return _numeroOperacion; }
			 set
			 {
				 if (_numeroOperacion != value)
				 {
					_numeroOperacion = value;
					 PropertyHasChanged("NumeroOperacion");
				 }
			 }
		}

		public int?  CajaAperturaId
		{
			 get { return _cajaAperturaId; }
			 set
			 {
				 if (_cajaAperturaId != value)
				 {
					_cajaAperturaId = value;
					 PropertyHasChanged("CajaAperturaId");
				 }
			 }
		}

		public DateTime?  FechaHoraAnulacion
		{
			 get { return _fechaHoraAnulacion; }
			 set
			 {
				 if (_fechaHoraAnulacion != value)
				 {
					_fechaHoraAnulacion = value;
					 PropertyHasChanged("FechaHoraAnulacion");
				 }
			 }
		}

		public int?  Estado
		{
			 get { return _estado; }
			 set
			 {
				 if (_estado != value)
				 {
					_estado = value;
					 PropertyHasChanged("Estado");
				 }
			 }
		}

		public string  UsuarioAnulacion
		{
			 get { return _usuarioAnulacion; }
			 set
			 {
				 if (_usuarioAnulacion != value)
				 {
					_usuarioAnulacion = value;
					 PropertyHasChanged("UsuarioAnulacion");
				 }
			 }
		}

		public int?  ConceptoId
		{
			 get { return _conceptoId; }
			 set
			 {
				 if (_conceptoId != value)
				 {
					_conceptoId = value;
					 PropertyHasChanged("ConceptoId");
				 }
			 }
		}

		public int?  TipoMovimiento
		{
			 get { return _tipoMovimiento; }
			 set
			 {
				 if (_tipoMovimiento != value)
				 {
					_tipoMovimiento = value;
					 PropertyHasChanged("TipoMovimiento");
				 }
			 }
		}

		public DateTime?  FechaHoraTransaccion
		{
			 get { return _fechaHoraTransaccion; }
			 set
			 {
				 if (_fechaHoraTransaccion != value)
				 {
					_fechaHoraTransaccion = value;
					 PropertyHasChanged("FechaHoraTransaccion");
				 }
			 }
		}

		public DateTime?  FechaHoraDescargo
		{
			 get { return _fechaHoraDescargo; }
			 set
			 {
				 if (_fechaHoraDescargo != value)
				 {
					_fechaHoraDescargo = value;
					 PropertyHasChanged("FechaHoraDescargo");
				 }
			 }
		}

		public bool  FlagImpreso
		{
			 get { return _flagImpreso; }
			 set
			 {
				 if (_flagImpreso != value)
				 {
					_flagImpreso = value;
					 PropertyHasChanged("FlagImpreso");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("NumeroDocumento", "NumeroDocumento"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodDocumento", "CodDocumento",6));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("OficinaIdProcedencia", "OficinaIdProcedencia",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("OficinaIdDestino", "OficinaIdDestino",10));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoPersona", "CodigoPersona",12));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("CodigoVoucher", "CodigoVoucher",20));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("NumeroOperacion", "NumeroOperacion",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UsuarioAnulacion", "UsuarioAnulacion",20));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("FlagImpreso", "FlagImpreso"));
		}

		#endregion

	}
}
