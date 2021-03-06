﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GW2NET.V2.WorldVersusWorld.Matches.Converters
{
    using System;

    using GW2NET.Common;
    using GW2NET.WorldVersusWorld;
	using CompetitiveMapDTO = GW2NET.V2.WorldVersusWorld.Matches.Json.CompetitiveMapDTO;

    public sealed partial class CompetitiveMapConverter : IConverter<CompetitiveMapDTO, CompetitiveMap>
	{
	    private readonly ITypeConverterFactory<CompetitiveMapDTO, CompetitiveMap> converterFactory;

		private CompetitiveMapConverter(ITypeConverterFactory<CompetitiveMapDTO, CompetitiveMap> converterFactory)
		{
		    if (converterFactory == null)
    		{
    		    throw new ArgumentNullException("converterFactory");
    		}

		    this.converterFactory = converterFactory;
		}

		 /// <inheritdoc />
        CompetitiveMap IConverter<CompetitiveMapDTO, CompetitiveMap>.Convert(CompetitiveMapDTO value, object state)
		{
		    if (value == null)
    		{
    		    throw new ArgumentNullException("value");
    		}

			string discriminator = value.Type;
			var converter = this.converterFactory.Create(discriminator);
			var entity = converter.Convert(value, value);
			this.Merge(entity, value, state);
			return entity;
		}

		// Implement this method in a buddy class to set properties that are specific to 'CompetitiveMap' (if any)
    	partial void Merge(CompetitiveMap entity, CompetitiveMapDTO dto, object state);

		/*
		// Use this template
		public partial class CompetitiveMapConverter
		{
		    partial void Merge(CompetitiveMap entity, CompetitiveMapDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
	}

#region BlueBorderlands
    /// <summary>Converts objects of type <see cref="CompetitiveMapDTO"/> to objects of type <see cref="BlueBorderlands"/>.</summary>
    public sealed partial class BlueBorderlandsConverter : IConverter<CompetitiveMapDTO, CompetitiveMap>
    {
	    /// <inheritdoc />
        public CompetitiveMap Convert(CompetitiveMapDTO value, object state)
        {
    		var entity = new BlueBorderlands();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'BlueBorderlands' (if any)
    	partial void Merge(BlueBorderlands entity, CompetitiveMapDTO dto, object state);

		/*
		// Use this template
		public partial class BlueBorderlandsConverter
		{
		    partial void Merge(BlueBorderlands entity, CompetitiveMapDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region EternalBattlegrounds
    /// <summary>Converts objects of type <see cref="CompetitiveMapDTO"/> to objects of type <see cref="EternalBattlegrounds"/>.</summary>
    public sealed partial class EternalBattlegroundsConverter : IConverter<CompetitiveMapDTO, CompetitiveMap>
    {
	    /// <inheritdoc />
        public CompetitiveMap Convert(CompetitiveMapDTO value, object state)
        {
    		var entity = new EternalBattlegrounds();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'EternalBattlegrounds' (if any)
    	partial void Merge(EternalBattlegrounds entity, CompetitiveMapDTO dto, object state);

		/*
		// Use this template
		public partial class EternalBattlegroundsConverter
		{
		    partial void Merge(EternalBattlegrounds entity, CompetitiveMapDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region GreenBorderlands
    /// <summary>Converts objects of type <see cref="CompetitiveMapDTO"/> to objects of type <see cref="GreenBorderlands"/>.</summary>
    public sealed partial class GreenBorderlandsConverter : IConverter<CompetitiveMapDTO, CompetitiveMap>
    {
	    /// <inheritdoc />
        public CompetitiveMap Convert(CompetitiveMapDTO value, object state)
        {
    		var entity = new GreenBorderlands();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'GreenBorderlands' (if any)
    	partial void Merge(GreenBorderlands entity, CompetitiveMapDTO dto, object state);

		/*
		// Use this template
		public partial class GreenBorderlandsConverter
		{
		    partial void Merge(GreenBorderlands entity, CompetitiveMapDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region RedBorderlands
    /// <summary>Converts objects of type <see cref="CompetitiveMapDTO"/> to objects of type <see cref="RedBorderlands"/>.</summary>
    public sealed partial class RedBorderlandsConverter : IConverter<CompetitiveMapDTO, CompetitiveMap>
    {
	    /// <inheritdoc />
        public CompetitiveMap Convert(CompetitiveMapDTO value, object state)
        {
    		var entity = new RedBorderlands();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'RedBorderlands' (if any)
    	partial void Merge(RedBorderlands entity, CompetitiveMapDTO dto, object state);

		/*
		// Use this template
		public partial class RedBorderlandsConverter
		{
		    partial void Merge(RedBorderlands entity, CompetitiveMapDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UnknownCompetitiveMap
    /// <summary>Converts objects of type <see cref="CompetitiveMapDTO"/> to objects of type <see cref="UnknownCompetitiveMap"/>.</summary>
    public sealed partial class UnknownCompetitiveMapConverter : IConverter<CompetitiveMapDTO, CompetitiveMap>
    {
	    /// <inheritdoc />
        public CompetitiveMap Convert(CompetitiveMapDTO value, object state)
        {
    		var entity = new UnknownCompetitiveMap();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'UnknownCompetitiveMap' (if any)
    	partial void Merge(UnknownCompetitiveMap entity, CompetitiveMapDTO dto, object state);

		/*
		// Use this template
		public partial class UnknownCompetitiveMapConverter
		{
		    partial void Merge(UnknownCompetitiveMap entity, CompetitiveMapDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

}
