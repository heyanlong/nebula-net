/**
 * Autogenerated by Thrift Compiler (0.15.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Nebula.Storage
{

  public partial class GetNeighborsRequest : TBase
  {
    private int _space_id;
    private List<byte[]> _column_names;
    private Dictionary<int, List<global::Nebula.Common.Row>> _parts;
    private global::Nebula.Storage.TraverseSpec _traverse_spec;
    private global::Nebula.Storage.RequestCommon _common;

    public int Space_id
    {
      get
      {
        return _space_id;
      }
      set
      {
        __isset.space_id = true;
        this._space_id = value;
      }
    }

    public List<byte[]> Column_names
    {
      get
      {
        return _column_names;
      }
      set
      {
        __isset.column_names = true;
        this._column_names = value;
      }
    }

    public Dictionary<int, List<global::Nebula.Common.Row>> Parts
    {
      get
      {
        return _parts;
      }
      set
      {
        __isset.parts = true;
        this._parts = value;
      }
    }

    public global::Nebula.Storage.TraverseSpec Traverse_spec
    {
      get
      {
        return _traverse_spec;
      }
      set
      {
        __isset.traverse_spec = true;
        this._traverse_spec = value;
      }
    }

    public global::Nebula.Storage.RequestCommon Common
    {
      get
      {
        return _common;
      }
      set
      {
        __isset.common = true;
        this._common = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool column_names;
      public bool parts;
      public bool traverse_spec;
      public bool common;
    }

    public GetNeighborsRequest()
    {
    }

    public GetNeighborsRequest DeepCopy()
    {
      var tmp86 = new GetNeighborsRequest();
      if(__isset.space_id)
      {
        tmp86.Space_id = this.Space_id;
      }
      tmp86.__isset.space_id = this.__isset.space_id;
      if((Column_names != null) && __isset.column_names)
      {
        tmp86.Column_names = this.Column_names.DeepCopy();
      }
      tmp86.__isset.column_names = this.__isset.column_names;
      if((Parts != null) && __isset.parts)
      {
        tmp86.Parts = this.Parts.DeepCopy();
      }
      tmp86.__isset.parts = this.__isset.parts;
      if((Traverse_spec != null) && __isset.traverse_spec)
      {
        tmp86.Traverse_spec = (global::Nebula.Storage.TraverseSpec)this.Traverse_spec.DeepCopy();
      }
      tmp86.__isset.traverse_spec = this.__isset.traverse_spec;
      if((Common != null) && __isset.common)
      {
        tmp86.Common = (global::Nebula.Storage.RequestCommon)this.Common.DeepCopy();
      }
      tmp86.__isset.common = this.__isset.common;
      return tmp86;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                Space_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list87 = await iprot.ReadListBeginAsync(cancellationToken);
                  Column_names = new List<byte[]>(_list87.Count);
                  for(int _i88 = 0; _i88 < _list87.Count; ++_i88)
                  {
                    byte[] _elem89;
                    _elem89 = await iprot.ReadBinaryAsync(cancellationToken);
                    Column_names.Add(_elem89);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Map)
              {
                {
                  TMap _map90 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Parts = new Dictionary<int, List<global::Nebula.Common.Row>>(_map90.Count);
                  for(int _i91 = 0; _i91 < _map90.Count; ++_i91)
                  {
                    int _key92;
                    List<global::Nebula.Common.Row> _val93;
                    _key92 = await iprot.ReadI32Async(cancellationToken);
                    {
                      TList _list94 = await iprot.ReadListBeginAsync(cancellationToken);
                      _val93 = new List<global::Nebula.Common.Row>(_list94.Count);
                      for(int _i95 = 0; _i95 < _list94.Count; ++_i95)
                      {
                        global::Nebula.Common.Row _elem96;
                        _elem96 = new global::Nebula.Common.Row();
                        await _elem96.ReadAsync(iprot, cancellationToken);
                        _val93.Add(_elem96);
                      }
                      await iprot.ReadListEndAsync(cancellationToken);
                    }
                    Parts[_key92] = _val93;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Struct)
              {
                Traverse_spec = new global::Nebula.Storage.TraverseSpec();
                await Traverse_spec.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Struct)
              {
                Common = new global::Nebula.Storage.RequestCommon();
                await Common.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp97 = new TStruct("GetNeighborsRequest");
        await oprot.WriteStructBeginAsync(tmp97, cancellationToken);
        var tmp98 = new TField();
        if(__isset.space_id)
        {
          tmp98.Name = "space_id";
          tmp98.Type = TType.I32;
          tmp98.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp98, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Column_names != null) && __isset.column_names)
        {
          tmp98.Name = "column_names";
          tmp98.Type = TType.List;
          tmp98.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp98, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.String, Column_names.Count), cancellationToken);
            foreach (byte[] _iter99 in Column_names)
            {
              await oprot.WriteBinaryAsync(_iter99, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Parts != null) && __isset.parts)
        {
          tmp98.Name = "parts";
          tmp98.Type = TType.Map;
          tmp98.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp98, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.I32, TType.List, Parts.Count), cancellationToken);
            foreach (int _iter100 in Parts.Keys)
            {
              await oprot.WriteI32Async(_iter100, cancellationToken);
              {
                await oprot.WriteListBeginAsync(new TList(TType.Struct, Parts[_iter100].Count), cancellationToken);
                foreach (global::Nebula.Common.Row _iter101 in Parts[_iter100])
                {
                  await _iter101.WriteAsync(oprot, cancellationToken);
                }
                await oprot.WriteListEndAsync(cancellationToken);
              }
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Traverse_spec != null) && __isset.traverse_spec)
        {
          tmp98.Name = "traverse_spec";
          tmp98.Type = TType.Struct;
          tmp98.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp98, cancellationToken);
          await Traverse_spec.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Common != null) && __isset.common)
        {
          tmp98.Name = "common";
          tmp98.Type = TType.Struct;
          tmp98.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp98, cancellationToken);
          await Common.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is GetNeighborsRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.column_names == other.__isset.column_names) && ((!__isset.column_names) || (TCollections.Equals(Column_names, other.Column_names))))
        && ((__isset.parts == other.__isset.parts) && ((!__isset.parts) || (TCollections.Equals(Parts, other.Parts))))
        && ((__isset.traverse_spec == other.__isset.traverse_spec) && ((!__isset.traverse_spec) || (System.Object.Equals(Traverse_spec, other.Traverse_spec))))
        && ((__isset.common == other.__isset.common) && ((!__isset.common) || (System.Object.Equals(Common, other.Common))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        if((Column_names != null) && __isset.column_names)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Column_names);
        }
        if((Parts != null) && __isset.parts)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Parts);
        }
        if((Traverse_spec != null) && __isset.traverse_spec)
        {
          hashcode = (hashcode * 397) + Traverse_spec.GetHashCode();
        }
        if((Common != null) && __isset.common)
        {
          hashcode = (hashcode * 397) + Common.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp102 = new StringBuilder("GetNeighborsRequest(");
      int tmp103 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp103++) { tmp102.Append(", "); }
        tmp102.Append("Space_id: ");
        Space_id.ToString(tmp102);
      }
      if((Column_names != null) && __isset.column_names)
      {
        if(0 < tmp103++) { tmp102.Append(", "); }
        tmp102.Append("Column_names: ");
        Column_names.ToString(tmp102);
      }
      if((Parts != null) && __isset.parts)
      {
        if(0 < tmp103++) { tmp102.Append(", "); }
        tmp102.Append("Parts: ");
        Parts.ToString(tmp102);
      }
      if((Traverse_spec != null) && __isset.traverse_spec)
      {
        if(0 < tmp103++) { tmp102.Append(", "); }
        tmp102.Append("Traverse_spec: ");
        Traverse_spec.ToString(tmp102);
      }
      if((Common != null) && __isset.common)
      {
        if(0 < tmp103++) { tmp102.Append(", "); }
        tmp102.Append("Common: ");
        Common.ToString(tmp102);
      }
      tmp102.Append(')');
      return tmp102.ToString();
    }
  }

}
