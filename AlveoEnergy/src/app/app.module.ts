import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { APP_INITIALIZER, NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatListModule } from '@angular/material/list';
import { MatPaginatorModule } from '@angular/material/paginator';
import '@angular/material/sort';
import { MatTableModule } from '@angular/material/table';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ZXingScannerModule } from '@zxing/ngx-scanner';
import { QRCodeModule } from 'angular2-qrcode';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app.routing.module';
import { BasicAuthInterceptor } from './basic-gaurd/auth.interceptor';
import { ErrorInterceptor } from './basic-gaurd/error.interceptor';
import { GanttComponent } from './components/gantt/gantt.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { LoginComponent } from './components/login/login.component';
import { OrdersComponent } from './components/orders/orders.component';
import { PersonnelComponent } from './components/personnel/personnel.component';
import { PersonnelAddComponent } from './components/personnel/personnelAdd/personnelAdd.component';
import { PersonnelGanttComponent } from './components/personnel_gantt/personnel.gantt.component';
import { ProjectsComponent } from './components/projects/projects.component';
import { PropertiesComponent } from './components/properties/properties.component';
import { QRCodeGenComponent } from './components/qr-code-generator/qr-code-gen.component';
import { QuoteComponent } from './components/quote/quote.component';
import { ScannerComponent } from './components/scanner/scanner.component';
import { VpnComponent } from "./components/vpn_passwords/vpn.component";
import { ConfigService } from './services/config.service';
import { CustomerService } from './services/customers.service';
import { GanttService } from './services/gantt.service';
import { InventoryService } from './services/inventory.service';
import { PersonnelService } from './services/personnel.service';
import { ProjectService } from './services/project.service';
import { QuoteService } from './services/quote.service';

@NgModule({
  declarations: [
    AppComponent,
    GanttComponent,
    PropertiesComponent,
    InventoryComponent,
    ProjectsComponent,
    PersonnelComponent,
    PersonnelAddComponent,
    ScannerComponent,
    OrdersComponent,
    QRCodeGenComponent,
    LoginComponent,
    QuoteComponent,
    VpnComponent,
    PersonnelGanttComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatListModule,
    MatButtonModule,
    MatTabsModule,
    MatTableModule,
    MatPaginatorModule,
    ZXingScannerModule,
    MatFormFieldModule,
    MatInputModule,
    QRCodeModule,
    FormsModule,
    ReactiveFormsModule,

  ],
  providers: [
    ConfigService,
    {
      provide: APP_INITIALIZER,
      useFactory: (configService: ConfigService) =>
      () => configService.loadAppsettings(),
      deps: [ConfigService],
      multi: true
    },
    InventoryService,
    ProjectService,
    GanttService,
    PersonnelService,
    CustomerService,
    QuoteService,
    { provide: HTTP_INTERCEPTORS, useClass: BasicAuthInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  bootstrap: [AppComponent],
  
})
export class AppModule { }
