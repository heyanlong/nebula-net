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

  public partial class CreateSessionResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Common.HostAddr _leader;
    private global::Nebula.Meta.Session _session;

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

    public global::Nebula.Meta.Session Session
    {
      get
      {
        return _session;
      }
      set
      {
        __isset.session = true;
        this._session = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool leader;
      public bool session;
    }

    public CreateSessionResp()
    {
    }

    public CreateSessionResp DeepCopy()
    {
      var tmp1048 = new CreateSessionResp();
      if(__isset.code)
      {
        tmp1048.Code = this.Code;
      }
      tmp1048.__isset.code = this.__isset.code;
      if((Leader != null) && __isset.leader)
      {
        tmp1048.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp1048.__isset.leader = this.__isset.leader;
      if((Session != null) && __isset.session)
      {
        tmp1048.Session = (global::Nebula.Meta.Session)this.Session.DeepCopy();
      }
      tmp1048.__isset.session = this.__isset.session;
      return tmp1048;
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
              if (field.Type == TType.Struct)
              {
                Session = new global::Nebula.Meta.Session();
                await Session.ReadAsync(iprot, cancellationToken);
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
        var tmp1049 = new TStruct("CreateSessionResp");
        await oprot.WriteStructBeginAsync(tmp1049, cancellationToken);
        var tmp1050 = new TField();
        if(__isset.code)
        {
          tmp1050.Name = "code";
          tmp1050.Type = TType.I32;
          tmp1050.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp1050, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp1050.Name = "leader";
          tmp1050.Type = TType.Struct;
          tmp1050.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp1050, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Session != null) && __isset.session)
        {
          tmp1050.Name = "session";
          tmp1050.Type = TType.Struct;
          tmp1050.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp1050, cancellationToken);
          await Session.WriteAsync(oprot, cancellationToken);
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
      if (!(that is CreateSessionResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))))
        && ((__isset.session == other.__isset.session) && ((!__isset.session) || (System.Object.Equals(Session, other.Session))));
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
        if((Session != null) && __isset.session)
        {
          hashcode = (hashcode * 397) + Session.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp1051 = new StringBuilder("CreateSessionResp(");
      int tmp1052 = 0;
      if(__isset.code)
      {
        if(0 < tmp1052++) { tmp1051.Append(", "); }
        tmp1051.Append("Code: ");
        Code.ToString(tmp1051);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp1052++) { tmp1051.Append(", "); }
        tmp1051.Append("Leader: ");
        Leader.ToString(tmp1051);
      }
      if((Session != null) && __isset.session)
      {
        if(0 < tmp1052++) { tmp1051.Append(", "); }
        tmp1051.Append("Session: ");
        Session.ToString(tmp1051);
      }
      tmp1051.Append(')');
      return tmp1051.ToString();
    }
  }

}
