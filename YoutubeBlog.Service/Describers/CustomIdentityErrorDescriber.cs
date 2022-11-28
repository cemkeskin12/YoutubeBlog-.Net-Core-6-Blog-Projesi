using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeBlog.Service.Describers
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return new IdentityError { Code = "PasswordRequiresUniqueChars", Description = $"En az {uniqueChars} farklı karakter içermelidir." };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError { Code = "DublicateEmail", Description = $"Bu email {email} adresine ait bir hesap zaten var." };
        }
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError { Code = "DuplicateUserName", Description = $"Bu email {userName} adresine ait bir hesap zaten var." };
        }
        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError { Code = "DublicateRoleName", Description = $"Bu rol {role} ismi zaten mevcut." };
        }
        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError { Code = "InvalidEmail", Description = $"Belirtilen email {email} adresi geçersizdir." };
        }
        public override IdentityError InvalidRoleName(string role)
        {
            return new IdentityError { Code = "InvalidRoleName", Description = $"Belirtilen rol {role} ismi geçersizdir." };
        }
        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError { Code = "InvalidUserName", Description = $"Belirtilen email {userName} adresi geçersizdir." };
        }
        public override IdentityError PasswordTooShort(int lenght)
        {
            return new IdentityError { Code = "PasswordTooShort", Description = $"Parola çok kısa ({lenght})." };
        }
        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError { Code = "UserAlreadyInRole", Description = $"Kullanıcı zaten bu role {role} sahip." };
        }
        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError { Code = "UserNotInRole", Description = $"Kullanıcı bu role {role} sahip değil!" };
        }
        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError { Code = "ConcurrencyFailture", Description = "Birden çok kullanıcı aynı veriyi değiştirmeye çalıştı! Değişiklikler geri alınacak!" };
        }
        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError { Code = "LoginAlreadyAssociated", Description = "Bu oturum zaten bir hesap ile ilişkili." };
        }
        public override IdentityError PasswordMismatch()
        {
            return new IdentityError { Code = "PasswordMismatch", Description = "Parola bilgisi uyuşmuyor." };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError { Code = "PasswordRequiresDigit", Description = "Parola en az 1 sayı içermelidir." };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError { Code = "PasswordRequiresNonAlphanumeric", Description = "Parolanız en az 2 farklı karaktere sahip olmalıdır." };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError { Code = "PasswordRequiresUpper", Description = "Parolanız en az 1 büyük harf içermelidir." };
        }
        public override IdentityError RecoveryCodeRedemptionFailed()
        {
            return new IdentityError { Code = "RecoveryCodeRedemptionFailed", Description = "Hesap kurtarma kodu geçersiz!" };
        }
        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError { Code = "UserAlreadyHasPassword", Description = "Kullanıcının zaten parolası var." };
        }
        public override IdentityError DefaultError()
        {
            return new IdentityError { Code = "DefaultError", Description = "Bir hata oluştu." };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError { Code = "PasswordRequiresLower", Description = "Parolanız en az 1 küçük harf içermelidir." };
        }
        public override IdentityError UserLockoutNotEnabled()
        {
            return new IdentityError { Code = "UserLockoutNotEnabled", Description = "Bu hesap şuanda kilitli! Lütfen daha sonra tekrar deneyin." };
        }
    }
}
