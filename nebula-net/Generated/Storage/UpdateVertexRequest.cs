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

  public partial class UpdateVertexRequest : TBase
  {
    private int _space_id;
    private int _part_id;
    private global::Nebula.Common.@Value _vertex_id;
    private List<global::Nebula.Storage.UpdatedProp> _updated_props;
    private bool _insertable;
    private List<byte[]> _return_props;
    private byte[] _condition;
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

    public int Part_id
    {
      get
      {
        return _part_id;
      }
      set
      {
        __isset.part_id = true;
        this._part_id = value;
      }
    }

    public global::Nebula.Common.@Value Vertex_id
    {
      get
      {
        return _vertex_id;
      }
      set
      {
        __isset.vertex_id = true;
        this._vertex_id = value;
      }
    }

    public int Tag_id { get; set; }

    public List<global::Nebula.Storage.UpdatedProp> Updated_props
    {
      get
      {
        return _updated_props;
      }
      set
      {
        __isset.updated_props = true;
        this._updated_props = value;
      }
    }

    public bool Insertable
    {
      get
      {
        return _insertable;
      }
      set
      {
        __isset.insertable = true;
        this._insertable = value;
      }
    }

    public List<byte[]> Return_props
    {
      get
      {
        return _return_props;
      }
      set
      {
        __isset.return_props = true;
        this._return_props = value;
      }
    }

    public byte[] Condition
    {
      get
      {
        return _condition;
      }
      set
      {
        __isset.condition = true;
        this._condition = value;
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
      public bool part_id;
      public bool vertex_id;
      public bool updated_props;
      public bool insertable;
      public bool return_props;
      public bool condition;
      public bool common;
    }

    public UpdateVertexRequest()
    {
      this._insertable = false;
      this.__isset.insertable = true;
    }

    public UpdateVertexRequest(int tag_id) : this()
    {
      this.Tag_id = tag_id;
    }

    public UpdateVertexRequest DeepCopy()
    {
      var tmp283 = new UpdateVertexRequest();
      if(__isset.space_id)
      {
        tmp283.Space_id = this.Space_id;
      }
      tmp283.__isset.space_id = this.__isset.space_id;
      if(__isset.part_id)
      {
        tmp283.Part_id = this.Part_id;
      }
      tmp283.__isset.part_id = this.__isset.part_id;
      if((Vertex_id != null) && __isset.vertex_id)
      {
        tmp283.Vertex_id = (global::Nebula.Common.@Value)this.Vertex_id.DeepCopy();
      }
      tmp283.__isset.vertex_id = this.__isset.vertex_id;
      tmp283.Tag_id = this.Tag_id;
      if((Updated_props != null) && __isset.updated_props)
      {
        tmp283.Updated_props = this.Updated_props.DeepCopy();
      }
      tmp283.__isset.updated_props = this.__isset.updated_props;
      if(__isset.insertable)
      {
        tmp283.Insertable = this.Insertable;
      }
      tmp283.__isset.insertable = this.__isset.insertable;
      if((Return_props != null) && __isset.return_props)
      {
        tmp283.Return_props = this.Return_props.DeepCopy();
      }
      tmp283.__isset.return_props = this.__isset.return_props;
      if((Condition != null) && __isset.condition)
      {
        tmp283.Condition = this.Condition.ToArray();
      }
      tmp283.__isset.condition = this.__isset.condition;
      if((Common != null) && __isset.common)
      {
        tmp283.Common = (global::Nebula.Storage.RequestCommon)this.Common.DeepCopy();
      }
      tmp283.__isset.common = this.__isset.common;
      return tmp283;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_tag_id = false;
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
              if (field.Type == TType.I32)
              {
                Part_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                Vertex_id = new global::Nebula.Common.@Value();
                await Vertex_id.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I32)
              {
                Tag_id = await iprot.ReadI32Async(cancellationToken);
                isset_tag_id = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.List)
              {
                {
                  TList _list284 = await iprot.ReadListBeginAsync(cancellationToken);
                  Updated_props = new List<global::Nebula.Storage.UpdatedProp>(_list284.Count);
                  for(int _i285 = 0; _i285 < _list284.Count; ++_i285)
                  {
                    global::Nebula.Storage.UpdatedProp _elem286;
                    _elem286 = new global::Nebula.Storage.UpdatedProp();
                    await _elem286.ReadAsync(iprot, cancellationToken);
                    Updated_props.Add(_elem286);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Bool)
              {
                Insertable = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.List)
              {
                {
                  TList _list287 = await iprot.ReadListBeginAsync(cancellationToken);
                  Return_props = new List<byte[]>(_list287.Count);
                  for(int _i288 = 0; _i288 < _list287.Count; ++_i288)
                  {
                    byte[] _elem289;
                    _elem289 = await iprot.ReadBinaryAsync(cancellationToken);
                    Return_props.Add(_elem289);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.String)
              {
                Condition = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
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
        if (!isset_tag_id)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
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
        var tmp290 = new TStruct("UpdateVertexRequest");
        await oprot.WriteStructBeginAsync(tmp290, cancellationToken);
        var tmp291 = new TField();
        if(__isset.space_id)
        {
          tmp291.Name = "space_id";
          tmp291.Type = TType.I32;
          tmp291.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp291, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.part_id)
        {
          tmp291.Name = "part_id";
          tmp291.Type = TType.I32;
          tmp291.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp291, cancellationToken);
          await oprot.WriteI32Async(Part_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Vertex_id != null) && __isset.vertex_id)
        {
          tmp291.Name = "vertex_id";
          tmp291.Type = TType.Struct;
          tmp291.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp291, cancellationToken);
          await Vertex_id.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        tmp291.Name = "tag_id";
        tmp291.Type = TType.I32;
        tmp291.ID = 4;
        await oprot.WriteFieldBeginAsync(tmp291, cancellationToken);
        await oprot.WriteI32Async(Tag_id, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if((Updated_props != null) && __isset.updated_props)
        {
          tmp291.Name = "updated_props";
          tmp291.Type = TType.List;
          tmp291.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp291, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Updated_props.Count), cancellationToken);
            foreach (global::Nebula.Storage.UpdatedProp _iter292 in Updated_props)
            {
              await _iter292.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.insertable)
        {
          tmp291.Name = "insertable";
          tmp291.Type = TType.Bool;
          tmp291.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp291, cancellationToken);
          await oprot.WriteBoolAsync(Insertable, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Return_props != null) && __isset.return_props)
        {
          tmp291.Name = "return_props";
          tmp291.Type = TType.List;
          tmp291.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp291, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.String, Return_props.Count), cancellationToken);
            foreach (byte[] _iter293 in Return_props)
            {
              await oprot.WriteBinaryAsync(_iter293, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Condition != null) && __isset.condition)
        {
          tmp291.Name = "condition";
          tmp291.Type = TType.String;
          tmp291.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp291, cancellationToken);
          await oprot.WriteBinaryAsync(Condition, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Common != null) && __isset.common)
        {
          tmp291.Name = "common";
          tmp291.Type = TType.Struct;
          tmp291.ID = 9;
          await oprot.WriteFieldBeginAsync(tmp291, cancellationToken);
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
      if (!(that is UpdateVertexRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.part_id == other.__isset.part_id) && ((!__isset.part_id) || (System.Object.Equals(Part_id, other.Part_id))))
        && ((__isset.vertex_id == other.__isset.vertex_id) && ((!__isset.vertex_id) || (System.Object.Equals(Vertex_id, other.Vertex_id))))
        && System.Object.Equals(Tag_id, other.Tag_id)
        && ((__isset.updated_props == other.__isset.updated_props) && ((!__isset.updated_props) || (TCollections.Equals(Updated_props, other.Updated_props))))
        && ((__isset.insertable == other.__isset.insertable) && ((!__isset.insertable) || (System.Object.Equals(Insertable, other.Insertable))))
        && ((__isset.return_props == other.__isset.return_props) && ((!__isset.return_props) || (TCollections.Equals(Return_props, other.Return_props))))
        && ((__isset.condition == other.__isset.condition) && ((!__isset.condition) || (TCollections.Equals(Condition, other.Condition))))
        && ((__isset.common == other.__isset.common) && ((!__isset.common) || (System.Object.Equals(Common, other.Common))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        if(__isset.part_id)
        {
          hashcode = (hashcode * 397) + Part_id.GetHashCode();
        }
        if((Vertex_id != null) && __isset.vertex_id)
        {
          hashcode = (hashcode * 397) + Vertex_id.GetHashCode();
        }
        hashcode = (hashcode * 397) + Tag_id.GetHashCode();
        if((Updated_props != null) && __isset.updated_props)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Updated_props);
        }
        if(__isset.insertable)
        {
          hashcode = (hashcode * 397) + Insertable.GetHashCode();
        }
        if((Return_props != null) && __isset.return_props)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Return_props);
        }
        if((Condition != null) && __isset.condition)
        {
          hashcode = (hashcode * 397) + Condition.GetHashCode();
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
      var tmp294 = new StringBuilder("UpdateVertexRequest(");
      int tmp295 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp295++) { tmp294.Append(", "); }
        tmp294.Append("Space_id: ");
        Space_id.ToString(tmp294);
      }
      if(__isset.part_id)
      {
        if(0 < tmp295++) { tmp294.Append(", "); }
        tmp294.Append("Part_id: ");
        Part_id.ToString(tmp294);
      }
      if((Vertex_id != null) && __isset.vertex_id)
      {
        if(0 < tmp295++) { tmp294.Append(", "); }
        tmp294.Append("Vertex_id: ");
        Vertex_id.ToString(tmp294);
      }
      if(0 < tmp295) { tmp294.Append(", "); }
      tmp294.Append("Tag_id: ");
      Tag_id.ToString(tmp294);
      if((Updated_props != null) && __isset.updated_props)
      {
        tmp294.Append(", Updated_props: ");
        Updated_props.ToString(tmp294);
      }
      if(__isset.insertable)
      {
        tmp294.Append(", Insertable: ");
        Insertable.ToString(tmp294);
      }
      if((Return_props != null) && __isset.return_props)
      {
        tmp294.Append(", Return_props: ");
        Return_props.ToString(tmp294);
      }
      if((Condition != null) && __isset.condition)
      {
        tmp294.Append(", Condition: ");
        Condition.ToString(tmp294);
      }
      if((Common != null) && __isset.common)
      {
        tmp294.Append(", Common: ");
        Common.ToString(tmp294);
      }
      tmp294.Append(')');
      return tmp294.ToString();
    }
  }

}
