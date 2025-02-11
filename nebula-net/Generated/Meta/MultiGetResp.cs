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

  public partial class MultiGetResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Common.HostAddr _leader;
    private List<byte[]> _values;

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

    public List<byte[]> Values
    {
      get
      {
        return _values;
      }
      set
      {
        __isset.values = true;
        this._values = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool leader;
      public bool values;
    }

    public MultiGetResp()
    {
    }

    public MultiGetResp DeepCopy()
    {
      var tmp406 = new MultiGetResp();
      if(__isset.code)
      {
        tmp406.Code = this.Code;
      }
      tmp406.__isset.code = this.__isset.code;
      if((Leader != null) && __isset.leader)
      {
        tmp406.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp406.__isset.leader = this.__isset.leader;
      if((Values != null) && __isset.values)
      {
        tmp406.Values = this.Values.DeepCopy();
      }
      tmp406.__isset.values = this.__isset.values;
      return tmp406;
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
              if (field.Type == TType.List)
              {
                {
                  TList _list407 = await iprot.ReadListBeginAsync(cancellationToken);
                  Values = new List<byte[]>(_list407.Count);
                  for(int _i408 = 0; _i408 < _list407.Count; ++_i408)
                  {
                    byte[] _elem409;
                    _elem409 = await iprot.ReadBinaryAsync(cancellationToken);
                    Values.Add(_elem409);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        var tmp410 = new TStruct("MultiGetResp");
        await oprot.WriteStructBeginAsync(tmp410, cancellationToken);
        var tmp411 = new TField();
        if(__isset.code)
        {
          tmp411.Name = "code";
          tmp411.Type = TType.I32;
          tmp411.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp411, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp411.Name = "leader";
          tmp411.Type = TType.Struct;
          tmp411.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp411, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Values != null) && __isset.values)
        {
          tmp411.Name = "values";
          tmp411.Type = TType.List;
          tmp411.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp411, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.String, Values.Count), cancellationToken);
            foreach (byte[] _iter412 in Values)
            {
              await oprot.WriteBinaryAsync(_iter412, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
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
      if (!(that is MultiGetResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))))
        && ((__isset.values == other.__isset.values) && ((!__isset.values) || (TCollections.Equals(Values, other.Values))));
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
        if((Values != null) && __isset.values)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Values);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp413 = new StringBuilder("MultiGetResp(");
      int tmp414 = 0;
      if(__isset.code)
      {
        if(0 < tmp414++) { tmp413.Append(", "); }
        tmp413.Append("Code: ");
        Code.ToString(tmp413);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp414++) { tmp413.Append(", "); }
        tmp413.Append("Leader: ");
        Leader.ToString(tmp413);
      }
      if((Values != null) && __isset.values)
      {
        if(0 < tmp414++) { tmp413.Append(", "); }
        tmp413.Append("Values: ");
        Values.ToString(tmp413);
      }
      tmp413.Append(')');
      return tmp413.ToString();
    }
  }

}
