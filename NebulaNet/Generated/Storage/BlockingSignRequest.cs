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

  public partial class BlockingSignRequest : TBase
  {
    private int _space_id;

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

    /// <summary>
    /// 
    /// <seealso cref="global::Nebula.Storage.EngineSignType"/>
    /// </summary>
    public global::Nebula.Storage.EngineSignType Sign { get; set; }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
    }

    public BlockingSignRequest()
    {
    }

    public BlockingSignRequest(global::Nebula.Storage.EngineSignType sign) : this()
    {
      this.Sign = sign;
    }

    public BlockingSignRequest DeepCopy()
    {
      var tmp465 = new BlockingSignRequest();
      if(__isset.space_id)
      {
        tmp465.Space_id = this.Space_id;
      }
      tmp465.__isset.space_id = this.__isset.space_id;
      tmp465.Sign = this.Sign;
      return tmp465;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_sign = false;
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
                Sign = (global::Nebula.Storage.EngineSignType)await iprot.ReadI32Async(cancellationToken);
                isset_sign = true;
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
        if (!isset_sign)
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
        var tmp466 = new TStruct("BlockingSignRequest");
        await oprot.WriteStructBeginAsync(tmp466, cancellationToken);
        var tmp467 = new TField();
        if(__isset.space_id)
        {
          tmp467.Name = "space_id";
          tmp467.Type = TType.I32;
          tmp467.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp467, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        tmp467.Name = "sign";
        tmp467.Type = TType.I32;
        tmp467.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp467, cancellationToken);
        await oprot.WriteI32Async((int)Sign, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
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
      if (!(that is BlockingSignRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && System.Object.Equals(Sign, other.Sign);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        hashcode = (hashcode * 397) + Sign.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp468 = new StringBuilder("BlockingSignRequest(");
      int tmp469 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp469++) { tmp468.Append(", "); }
        tmp468.Append("Space_id: ");
        Space_id.ToString(tmp468);
      }
      if(0 < tmp469) { tmp468.Append(", "); }
      tmp468.Append("Sign: ");
      Sign.ToString(tmp468);
      tmp468.Append(')');
      return tmp468.ToString();
    }
  }

}
