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

namespace Nebula.Common
{

  public partial class CheckpointInfo : TBase
  {
    private global::Nebula.Common.PartitionBackupInfo _partition_info;
    private byte[] _path;

    public global::Nebula.Common.PartitionBackupInfo Partition_info
    {
      get
      {
        return _partition_info;
      }
      set
      {
        __isset.partition_info = true;
        this._partition_info = value;
      }
    }

    public byte[] Path
    {
      get
      {
        return _path;
      }
      set
      {
        __isset.path = true;
        this._path = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool partition_info;
      public bool path;
    }

    public CheckpointInfo()
    {
    }

    public CheckpointInfo DeepCopy()
    {
      var tmp199 = new CheckpointInfo();
      if((Partition_info != null) && __isset.partition_info)
      {
        tmp199.Partition_info = (global::Nebula.Common.PartitionBackupInfo)this.Partition_info.DeepCopy();
      }
      tmp199.__isset.partition_info = this.__isset.partition_info;
      if((Path != null) && __isset.path)
      {
        tmp199.Path = this.Path.ToArray();
      }
      tmp199.__isset.path = this.__isset.path;
      return tmp199;
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
              if (field.Type == TType.Struct)
              {
                Partition_info = new global::Nebula.Common.PartitionBackupInfo();
                await Partition_info.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Path = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp200 = new TStruct("CheckpointInfo");
        await oprot.WriteStructBeginAsync(tmp200, cancellationToken);
        var tmp201 = new TField();
        if((Partition_info != null) && __isset.partition_info)
        {
          tmp201.Name = "partition_info";
          tmp201.Type = TType.Struct;
          tmp201.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp201, cancellationToken);
          await Partition_info.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Path != null) && __isset.path)
        {
          tmp201.Name = "path";
          tmp201.Type = TType.String;
          tmp201.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp201, cancellationToken);
          await oprot.WriteBinaryAsync(Path, cancellationToken);
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
      if (!(that is CheckpointInfo other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.partition_info == other.__isset.partition_info) && ((!__isset.partition_info) || (System.Object.Equals(Partition_info, other.Partition_info))))
        && ((__isset.path == other.__isset.path) && ((!__isset.path) || (TCollections.Equals(Path, other.Path))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Partition_info != null) && __isset.partition_info)
        {
          hashcode = (hashcode * 397) + Partition_info.GetHashCode();
        }
        if((Path != null) && __isset.path)
        {
          hashcode = (hashcode * 397) + Path.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp202 = new StringBuilder("CheckpointInfo(");
      int tmp203 = 0;
      if((Partition_info != null) && __isset.partition_info)
      {
        if(0 < tmp203++) { tmp202.Append(", "); }
        tmp202.Append("Partition_info: ");
        Partition_info.ToString(tmp202);
      }
      if((Path != null) && __isset.path)
      {
        if(0 < tmp203++) { tmp202.Append(", "); }
        tmp202.Append("Path: ");
        Path.ToString(tmp202);
      }
      tmp202.Append(')');
      return tmp202.ToString();
    }
  }

}
