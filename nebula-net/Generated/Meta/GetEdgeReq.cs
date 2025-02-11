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

namespace Nebula.Meta
{

  public partial class GetEdgeReq : TBase
  {
    private int _space_id;
    private byte[] _edge_name;
    private long _version;

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

    public byte[] Edge_name
    {
      get
      {
        return _edge_name;
      }
      set
      {
        __isset.edge_name = true;
        this._edge_name = value;
      }
    }

    public long Version
    {
      get
      {
        return _version;
      }
      set
      {
        __isset.version = true;
        this._version = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool edge_name;
      public bool version;
    }

    public GetEdgeReq()
    {
    }

    public GetEdgeReq DeepCopy()
    {
      var tmp280 = new GetEdgeReq();
      if(__isset.space_id)
      {
        tmp280.Space_id = this.Space_id;
      }
      tmp280.__isset.space_id = this.__isset.space_id;
      if((Edge_name != null) && __isset.edge_name)
      {
        tmp280.Edge_name = this.Edge_name.ToArray();
      }
      tmp280.__isset.edge_name = this.__isset.edge_name;
      if(__isset.version)
      {
        tmp280.Version = this.Version;
      }
      tmp280.__isset.version = this.__isset.version;
      return tmp280;
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
              if (field.Type == TType.String)
              {
                Edge_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Version = await iprot.ReadI64Async(cancellationToken);
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
        var tmp281 = new TStruct("GetEdgeReq");
        await oprot.WriteStructBeginAsync(tmp281, cancellationToken);
        var tmp282 = new TField();
        if(__isset.space_id)
        {
          tmp282.Name = "space_id";
          tmp282.Type = TType.I32;
          tmp282.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp282, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Edge_name != null) && __isset.edge_name)
        {
          tmp282.Name = "edge_name";
          tmp282.Type = TType.String;
          tmp282.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp282, cancellationToken);
          await oprot.WriteBinaryAsync(Edge_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.version)
        {
          tmp282.Name = "version";
          tmp282.Type = TType.I64;
          tmp282.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp282, cancellationToken);
          await oprot.WriteI64Async(Version, cancellationToken);
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
      if (!(that is GetEdgeReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.edge_name == other.__isset.edge_name) && ((!__isset.edge_name) || (TCollections.Equals(Edge_name, other.Edge_name))))
        && ((__isset.version == other.__isset.version) && ((!__isset.version) || (System.Object.Equals(Version, other.Version))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        if((Edge_name != null) && __isset.edge_name)
        {
          hashcode = (hashcode * 397) + Edge_name.GetHashCode();
        }
        if(__isset.version)
        {
          hashcode = (hashcode * 397) + Version.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp283 = new StringBuilder("GetEdgeReq(");
      int tmp284 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp284++) { tmp283.Append(", "); }
        tmp283.Append("Space_id: ");
        Space_id.ToString(tmp283);
      }
      if((Edge_name != null) && __isset.edge_name)
      {
        if(0 < tmp284++) { tmp283.Append(", "); }
        tmp283.Append("Edge_name: ");
        Edge_name.ToString(tmp283);
      }
      if(__isset.version)
      {
        if(0 < tmp284++) { tmp283.Append(", "); }
        tmp283.Append("Version: ");
        Version.ToString(tmp283);
      }
      tmp283.Append(')');
      return tmp283.ToString();
    }
  }

}
