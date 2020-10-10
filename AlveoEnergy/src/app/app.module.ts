import { BrowserModule } from '@angular/platform-browser';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { AppComponent } from './app.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { InventoryService } from './services/inventory.service';
import { GanttComponent } from './components/gantt/gantt.component';
import { PropertiesComponent } from './components/properties/properties.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { AppRoutingModule } from './app.routing.module';
import { ProjectsComponent } from './components/projects/projects.component';
import { PersonnelComponent } from './components/personnel/personnel.component';
import { PersonnelAddComponent } from './components/personnel/personnelAdd/personnelAdd.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatListModule } from '@angular/material/list';
import { MatButtonModule } from '@angular/material/button';
import { ProjectService } from './services/project.service';
import { GanttService } from './services/gantt.service';
import { MatTabsModule } from '@angular/material/tabs';
import { PersonnelService } from './services/personnel.service';
import { ZXingScannerModule } from '@zxing/ngx-scanner';
import { ScannerComponent } from './components/scanner/scanner.component';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import '@angular/material/sort';
import { MatFormFieldModule} from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input'
import { OrdersComponent } from './components/orders/orders.component'
import { ConfigService } from './services/config.service';
import { QRCodeGenComponent } from './components/qr-code-generator/qr-code-gen.component';
import { QRCodeModule } from 'angular2-qrcode';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule} from '@angular/forms';
import { LoginComponent } from './components/login/login.component';
import { BasicAuthInterceptor } from './basic-gaurd/auth.interceptor';
import { ErrorInterceptor } from './basic-gaurd/error.interceptor';
import { QuoteComponent } from './components/quote/quote.component';
import { CustomerService } from './services/customers.service';
import { VpnComponent } from "./components/vpn_passwords/vpn.component";
import { QuoteService } from './services/quote.service';
import { PersonnelGanttComponent } from "./personnel_gantt/personnel.gantt.component";




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
