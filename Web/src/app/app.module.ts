import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { LoginComponent } from './login/login.component';
import { PackageComponent } from './package/package.component';

import { AuthService } from './auth/auth.service';
import { AuthGuard } from './auth/auth-guard';
import { HttpInterceptorModule } from './auth/http-interceptor.module';
import { HasClaimDirective } from './auth/has-claim.directive';
import { PackageService } from './package/package.service';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    PackageComponent,
    HasClaimDirective
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    HttpInterceptorModule
  ],
  providers: [PackageService, AuthService, AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
