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

  public partial class ExecResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Meta.ID _id;
    private global::Nebula.Common.HostAddr _leader;

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

    public global::Nebula.Meta.ID Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
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


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool id;
      public bool leader;
    }

    public ExecResp()
    {
    }

    public ExecResp DeepCopy()
    {
      var tmp101 = new ExecResp();
      if(__isset.code)
      {
        tmp101.Code = this.Code;
      }
      tmp101.__isset.code = this.__isset.code;
      if((Id != null) && __isset.id)
      {
        tmp101.Id = (global::Nebula.Meta.ID)this.Id.DeepCopy();
      }
      tmp101.__isset.id = this.__isset.id;
      if((Leader != null) && __isset.leader)
      {
        tmp101.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp101.__isset.leader = this.__isset.leader;
      return tmp101;
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
                Id = new global::Nebula.Meta.ID();
                await Id.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
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
        var tmp102 = new TStruct("ExecResp");
        await oprot.WriteStructBeginAsync(tmp102, cancellationToken);
        var tmp103 = new TField();
        if(__isset.code)
        {
          tmp103.Name = "code";
          tmp103.Type = TType.I32;
          tmp103.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp103, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Id != null) && __isset.id)
        {
          tmp103.Name = "id";
          tmp103.Type = TType.Struct;
          tmp103.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp103, cancellationToken);
          await Id.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp103.Name = "leader";
          tmp103.Type = TType.Struct;
          tmp103.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp103, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
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
      if (!(that is ExecResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.id == other.__isset.id) && ((!__isset.id) || (System.Object.Equals(Id, other.Id))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.code)
        {
          hashcode = (hashcode * 397) + Code.GetHashCode();
        }
        if((Id != null) && __isset.id)
        {
          hashcode = (hashcode * 397) + Id.GetHashCode();
        }
        if((Leader != null) && __isset.leader)
        {
          hashcode = (hashcode * 397) + Leader.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp104 = new StringBuilder("ExecResp(");
      int tmp105 = 0;
      if(__isset.code)
      {
        if(0 < tmp105++) { tmp104.Append(", "); }
        tmp104.Append("Code: ");
        Code.ToString(tmp104);
      }
      if((Id != null) && __isset.id)
      {
        if(0 < tmp105++) { tmp104.Append(", "); }
        tmp104.Append("Id: ");
        Id.ToString(tmp104);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp105++) { tmp104.Append(", "); }
        tmp104.Append("Leader: ");
        Leader.ToString(tmp104);
      }
      tmp104.Append(')');
      return tmp104.ToString();
    }
  }

}
