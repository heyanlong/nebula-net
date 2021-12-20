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

  public partial class HBResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Common.HostAddr _leader;
    private long _cluster_id;
    private long _last_update_time_in_ms;
    private int _meta_version;

    /// <summary>
    /// 
    /// <seealso cref="global::Nebula.Common.ErrorCode"/>
    /// </summary>
    public global::Nebula.Common.ErrorCode Code
    {
      get
      {
        return _code;
      }
      set
      {
        __isset.code = true;
        this._code = value;
      }
    }

    public global::Nebula.Common.HostAddr Leader
    {
      get
      {
        return _leader;
      }
      set
      {
        __isset.leader = true;
        this._leader = value;
      }
    }

    public long Cluster_id
    {
      get
      {
        return _cluster_id;
      }
      set
      {
        __isset.cluster_id = true;
        this._cluster_id = value;
      }
    }

    public long Last_update_time_in_ms
    {
      get
      {
        return _last_update_time_in_ms;
      }
      set
      {
        __isset.last_update_time_in_ms = true;
        this._last_update_time_in_ms = value;
      }
    }

    public int Meta_version
    {
      get
      {
        return _meta_version;
      }
      set
      {
        __isset.meta_version = true;
        this._meta_version = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool leader;
      public bool cluster_id;
      public bool last_update_time_in_ms;
      public bool meta_version;
    }

    public HBResp()
    {
    }

    public HBResp DeepCopy()
    {
      var tmp439 = new HBResp();
      if(__isset.code)
      {
        tmp439.Code = this.Code;
      }
      tmp439.__isset.code = this.__isset.code;
      if((Leader != null) && __isset.leader)
      {
        tmp439.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp439.__isset.leader = this.__isset.leader;
      if(__isset.cluster_id)
      {
        tmp439.Cluster_id = this.Cluster_id;
      }
      tmp439.__isset.cluster_id = this.__isset.cluster_id;
      if(__isset.last_update_time_in_ms)
      {
        tmp439.Last_update_time_in_ms = this.Last_update_time_in_ms;
      }
      tmp439.__isset.last_update_time_in_ms = this.__isset.last_update_time_in_ms;
      if(__isset.meta_version)
      {
        tmp439.Meta_version = this.Meta_version;
      }
      tmp439.__isset.meta_version = this.__isset.meta_version;
      return tmp439;
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
                Code = (global::Nebula.Common.ErrorCode)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Leader = new global::Nebula.Common.HostAddr();
                await Leader.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Cluster_id = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                Last_update_time_in_ms = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I32)
              {
                Meta_version = await iprot.ReadI32Async(cancellationToken);
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
        var tmp440 = new TStruct("HBResp");
        await oprot.WriteStructBeginAsync(tmp440, cancellationToken);
        var tmp441 = new TField();
        if(__isset.code)
        {
          tmp441.Name = "code";
          tmp441.Type = TType.I32;
          tmp441.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp441, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp441.Name = "leader";
          tmp441.Type = TType.Struct;
          tmp441.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp441, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.cluster_id)
        {
          tmp441.Name = "cluster_id";
          tmp441.Type = TType.I64;
          tmp441.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp441, cancellationToken);
          await oprot.WriteI64Async(Cluster_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.last_update_time_in_ms)
        {
          tmp441.Name = "last_update_time_in_ms";
          tmp441.Type = TType.I64;
          tmp441.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp441, cancellationToken);
          await oprot.WriteI64Async(Last_update_time_in_ms, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.meta_version)
        {
          tmp441.Name = "meta_version";
          tmp441.Type = TType.I32;
          tmp441.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp441, cancellationToken);
          await oprot.WriteI32Async(Meta_version, cancellationToken);
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
      if (!(that is HBResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))))
        && ((__isset.cluster_id == other.__isset.cluster_id) && ((!__isset.cluster_id) || (System.Object.Equals(Cluster_id, other.Cluster_id))))
        && ((__isset.last_update_time_in_ms == other.__isset.last_update_time_in_ms) && ((!__isset.last_update_time_in_ms) || (System.Object.Equals(Last_update_time_in_ms, other.Last_update_time_in_ms))))
        && ((__isset.meta_version == other.__isset.meta_version) && ((!__isset.meta_version) || (System.Object.Equals(Meta_version, other.Meta_version))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.code)
        {
          hashcode = (hashcode * 397) + Code.GetHashCode();
        }
        if((Leader != null) && __isset.leader)
        {
          hashcode = (hashcode * 397) + Leader.GetHashCode();
        }
        if(__isset.cluster_id)
        {
          hashcode = (hashcode * 397) + Cluster_id.GetHashCode();
        }
        if(__isset.last_update_time_in_ms)
        {
          hashcode = (hashcode * 397) + Last_update_time_in_ms.GetHashCode();
        }
        if(__isset.meta_version)
        {
          hashcode = (hashcode * 397) + Meta_version.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp442 = new StringBuilder("HBResp(");
      int tmp443 = 0;
      if(__isset.code)
      {
        if(0 < tmp443++) { tmp442.Append(", "); }
        tmp442.Append("Code: ");
        Code.ToString(tmp442);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp443++) { tmp442.Append(", "); }
        tmp442.Append("Leader: ");
        Leader.ToString(tmp442);
      }
      if(__isset.cluster_id)
      {
        if(0 < tmp443++) { tmp442.Append(", "); }
        tmp442.Append("Cluster_id: ");
        Cluster_id.ToString(tmp442);
      }
      if(__isset.last_update_time_in_ms)
      {
        if(0 < tmp443++) { tmp442.Append(", "); }
        tmp442.Append("Last_update_time_in_ms: ");
        Last_update_time_in_ms.ToString(tmp442);
      }
      if(__isset.meta_version)
      {
        if(0 < tmp443++) { tmp442.Append(", "); }
        tmp442.Append("Meta_version: ");
        Meta_version.ToString(tmp442);
      }
      tmp442.Append(')');
      return tmp442.ToString();
    }
  }

}
