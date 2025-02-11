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

  public partial class GetResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Common.HostAddr _leader;
    private byte[] _value;

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

    public byte[] Value
    {
      get
      {
        return _value;
      }
      set
      {
        __isset.@value = true;
        this._value = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool leader;
      public bool @value;
    }

    public GetResp()
    {
    }

    public GetResp DeepCopy()
    {
      var tmp392 = new GetResp();
      if(__isset.code)
      {
        tmp392.Code = this.Code;
      }
      tmp392.__isset.code = this.__isset.code;
      if((Leader != null) && __isset.leader)
      {
        tmp392.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp392.__isset.leader = this.__isset.leader;
      if((Value != null) && __isset.@value)
      {
        tmp392.Value = this.Value.ToArray();
      }
      tmp392.__isset.@value = this.__isset.@value;
      return tmp392;
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
              if (field.Type == TType.String)
              {
                Value = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp393 = new TStruct("GetResp");
        await oprot.WriteStructBeginAsync(tmp393, cancellationToken);
        var tmp394 = new TField();
        if(__isset.code)
        {
          tmp394.Name = "code";
          tmp394.Type = TType.I32;
          tmp394.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp394, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp394.Name = "leader";
          tmp394.Type = TType.Struct;
          tmp394.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp394, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Value != null) && __isset.@value)
        {
          tmp394.Name = "value";
          tmp394.Type = TType.String;
          tmp394.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp394, cancellationToken);
          await oprot.WriteBinaryAsync(Value, cancellationToken);
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
      if (!(that is GetResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))))
        && ((__isset.@value == other.__isset.@value) && ((!__isset.@value) || (TCollections.Equals(Value, other.Value))));
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
        if((Value != null) && __isset.@value)
        {
          hashcode = (hashcode * 397) + Value.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp395 = new StringBuilder("GetResp(");
      int tmp396 = 0;
      if(__isset.code)
      {
        if(0 < tmp396++) { tmp395.Append(", "); }
        tmp395.Append("Code: ");
        Code.ToString(tmp395);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp396++) { tmp395.Append(", "); }
        tmp395.Append("Leader: ");
        Leader.ToString(tmp395);
      }
      if((Value != null) && __isset.@value)
      {
        if(0 < tmp396++) { tmp395.Append(", "); }
        tmp395.Append("Value: ");
        Value.ToString(tmp395);
      }
      tmp395.Append(')');
      return tmp395.ToString();
    }
  }

}
