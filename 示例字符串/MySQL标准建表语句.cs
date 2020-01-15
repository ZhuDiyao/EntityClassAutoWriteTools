using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 示例字符串
{
    public class MySQL标准建表语句
    {
        public static string str = @"--这是IT技术支持
CREATE TABLE `InformationTechnologySupportService`.`Untitled` (
  `id` int(11) NOT NULL AUTO_INCREMENT,--主键
  `user_phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,--用户电话
  `user_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,--用户名字
  `solveTime` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,--解决时间
  `processingPerson` varchar(255) CHARACTER SET utf8 COLLATE utf8_bin NULL DEFAULT NULL,--处理人
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_bin ROW_FORMAT = Compact;

";
    }
}
