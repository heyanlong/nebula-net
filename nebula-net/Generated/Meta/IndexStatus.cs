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

  public partial class IndexStatus : TBase
  {
    private byte[] _name;
    private byte[] _status;

    public byte[] Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public byte[] Status
    {
      get
      {
        return _status;
      }
      set
      {
        __isset.status = true;
        this._status = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool name;
      public bool status;
    }

    public IndexStatus()
    {
    }

    public IndexStatus DeepCopy()
    {
      var tmp718 = new IndexStatus();
      if((Name != null) && __isset.name)
      {
        tmp718.Name = this.Name.ToArray();
      }
      tmp718.__isset.name = this.__isset.name;
      if((Status != null) && __isset.status)
      {
        tmp718.Status = this.Status.ToArray();
      }
      tmp718.__isset.status = this.__isset.status;
      return tmp718;
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
              if (field.Type == TType.String)
              {
                Name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Status = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp719 = new TStruct("IndexStatus");
        await oprot.WriteStructBeginAsync(tmp719, cancellationToken);
        var tmp720 = new TField();
        if((Name != null) && __isset.name)
        {
          tmp720.Name = "name";
          tmp720.Type = TType.String;
          tmp720.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp720, cancellationToken);
          await oprot.WriteBinaryAsync(Name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Status != null) && __isset.status)
        {
          tmp720.Name = "status";
          tmp720.Type = TType.String;
          tmp720.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp720, cancellationToken);
          await oprot.WriteBinaryAsync(Status, cancellationToken);
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
      if (!(that is IndexStatus other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.name == other.__isset.name) && ((!__isset.name) || (TCollections.Equals(Name, other.Name))))
        && ((__isset.status == other.__isset.status) && ((!__isset.status) || (TCollections.Equals(Status, other.Status))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Name != null) && __isset.name)
        {
          hashcode = (hashcode * 397) + Name.GetHashCode();
        }
        if((Status != null) && __isset.status)
        {
          hashcode = (hashcode * 397) + Status.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp721 = new StringBuilder("IndexStatus(");
      int tmp722 = 0;
      if((Name != null) && __isset.name)
      {
        if(0 < tmp722++) { tmp721.Append(", "); }
        tmp721.Append("Name: ");
        Name.ToString(tmp721);
      }
      if((Status != null) && __isset.status)
      {
        if(0 < tmp722++) { tmp721.Append(", "); }
        tmp721.Append("Status: ");
        Status.ToString(tmp721);
      }
      tmp721.Append(')');
      return tmp721.ToString();
    }
  }

}
