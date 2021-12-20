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

  public partial class AdminExecResp : TBase
  {
    private global::Nebula.Meta.StatsItem _stats;

    public global::Nebula.Storage.ResponseCommon Result { get; set; }

    public global::Nebula.Meta.StatsItem Stats
    {
      get
      {
        return _stats;
      }
      set
      {
        __isset.stats = true;
        this._stats = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool stats;
    }

    public AdminExecResp()
    {
    }

    public AdminExecResp(global::Nebula.Storage.ResponseCommon result) : this()
    {
      this.Result = result;
    }

    public AdminExecResp DeepCopy()
    {
      var tmp412 = new AdminExecResp();
      if((Result != null))
      {
        tmp412.Result = (global::Nebula.Storage.ResponseCommon)this.Result.DeepCopy();
      }
      if((Stats != null) && __isset.stats)
      {
        tmp412.Stats = (global::Nebula.Meta.StatsItem)this.Stats.DeepCopy();
      }
      tmp412.__isset.stats = this.__isset.stats;
      return tmp412;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_result = false;
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
              if (field.Type == TType.Struct)
              {
                Result = new global::Nebula.Storage.ResponseCommon();
                await Result.ReadAsync(iprot, cancellationToken);
                isset_result = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Stats = new global::Nebula.Meta.StatsItem();
                await Stats.ReadAsync(iprot, cancellationToken);
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
        if (!isset_result)
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
        var tmp413 = new TStruct("AdminExecResp");
        await oprot.WriteStructBeginAsync(tmp413, cancellationToken);
        var tmp414 = new TField();
        if((Result != null))
        {
          tmp414.Name = "result";
          tmp414.Type = TType.Struct;
          tmp414.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp414, cancellationToken);
          await Result.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Stats != null) && __isset.stats)
        {
          tmp414.Name = "stats";
          tmp414.Type = TType.Struct;
          tmp414.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp414, cancellationToken);
          await Stats.WriteAsync(oprot, cancellationToken);
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
      if (!(that is AdminExecResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Result, other.Result)
        && ((__isset.stats == other.__isset.stats) && ((!__isset.stats) || (System.Object.Equals(Stats, other.Stats))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Result != null))
        {
          hashcode = (hashcode * 397) + Result.GetHashCode();
        }
        if((Stats != null) && __isset.stats)
        {
          hashcode = (hashcode * 397) + Stats.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp415 = new StringBuilder("AdminExecResp(");
      if((Result != null))
      {
        tmp415.Append(", Result: ");
        Result.ToString(tmp415);
      }
      if((Stats != null) && __isset.stats)
      {
        tmp415.Append(", Stats: ");
        Stats.ToString(tmp415);
      }
      tmp415.Append(')');
      return tmp415.ToString();
    }
  }

}
